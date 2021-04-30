using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Data.OleDb;
using System.Speech.Synthesis;
using System.Media;
using System.Runtime.InteropServices;

namespace Reconocimiento_facial
{
    public partial class Frm_Reconocimiento : Form
    {
        public int heigth, width;
        public string[] Labels;
        public string[] LabelsCed;
        DataBase dbc = new DataBase();
        int con = 0;
        SoundPlayer media = new SoundPlayer();
        SpeechSynthesizer vos = new SpeechSynthesizer();
        //DECLARANDO TODAS LAS VARIABLES, vectores y  haarcascades
        Image<Bgr, Byte> currentFrame;
        Capture grabber;
        HaarCascade face;
        HaarCascade eye;
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.4d, 0.4d);
        Image<Gray, byte> result, TrainedFace = null;
        Image<Gray, byte> resultCed, TrainedFaceCD = null;
        Image<Gray, byte> resultFN, TrainedFaceFN = null;
        Image<Gray, byte> resultSangre, TrainedFaceSG = null;
        Image<Gray, byte> resultAlergias, TrainedFaceAL = null;


        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> labelsCed = new List<string>();
        List<string> labelsFecha = new List<string>();
        List<string> labelsSangre = new List<string>();
        List<string> labelsAlergia = new List<string>();


        List<string> NamePersons = new List<string>();
        List<string> CedulaPersons = new List<string>();
        List<string> Fecha_NaciPersons = new List<string>();
        List<string> SangrePersons = new List<string>();
        List<string> AlergiaPersons = new List<string>();
        int ContTrain, NumLabels, t;
        string name, Labelsinfo, names = null;
        string Cedula, Cedulasinfo, Cedulas = null;
        string Fecha_Nacimiento, Fecha_Nacimientoinfo, Fecha_Nacimientos = null;
        string Sangre, Sangreinfo, Sangress = null;
        string Alergia, Alergiasinfo, Alergiass = null;

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Inicio f = new Inicio();
            f.Show();
            this.Close();
        }

        private void imageBoxFrameGrabber_Click(object sender, EventArgs e)
        {

        }

        public Frm_Reconocimiento()
        {
            InitializeComponent();
            heigth = this.Height; width = this.Width;
            //GARGAMOS LA DETECCION DE LAS CARAS POR  haarcascades 
            face = new HaarCascade("haarcascade_frontalface_default.xml");
            try
            {
                dbc.ObtenerBytesImagen();
                //carga de caras y etiquetas para cada imagen               
                string[] Labels = dbc.Name;
                string[] LabelsCed = dbc.Cedula;
                string[] LabelsFecha = dbc.Fecha_Naci;
                string[] LabelsSangre = dbc.Sangre;
                string[] LabelsAlergia = dbc.Alergias;
                NumLabels = dbc.TotalUser;
                ContTrain = NumLabels;
                string LoadFaces;

                for (int tf = 0; tf < NumLabels; tf++)
                {
                    con = tf;
                    Bitmap bmp = new Bitmap(dbc.ConvertByteToImg(con));
                    //LoadFaces = "face" + tf + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(bmp));//cargo la foto con ese nombre
                    labels.Add(Labels[tf]);//cargo el nombre que se encuentre en la posicion del tf
                    labelsCed.Add(LabelsCed[tf]);//cargo el nombre que se encuentre en la posicion del tf
                    labelsFecha.Add(LabelsFecha[tf]);
                    labelsSangre.Add(LabelsSangre[tf]);
                    labelsAlergia.Add(LabelsAlergia[tf]);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e + "No hay ningun rosto registrado).", "Cargar rostros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void Reconocer()
        {
            try
            {
                //Iniciar el dispositivo de captura
                grabber = new Capture();
                grabber.QueryFrame();
                //Iniciar el evento FrameGraber
                Application.Idle += new EventHandler(FrameGrabber);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FrameGrabber(object sender, EventArgs e)
        {
            lblNumeroDetect.Text = "0";
            NamePersons.Add("");
            CedulaPersons.Add("");
            Fecha_NaciPersons.Add("");
            SangrePersons.Add("");
            AlergiaPersons.Add("");


            try
            {
                currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                //Convertir a escala de grises
                gray = currentFrame.Convert<Gray, Byte>();

                //Detector de Rostros
                MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(face, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));

                //Accion para cada elemento detectado
                foreach (MCvAvgComp f in facesDetected[0])
                {
                    t = t + 1;
                    result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, INTER.CV_INTER_CUBIC);
                    resultCed = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, INTER.CV_INTER_CUBIC);
                    resultFN = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, INTER.CV_INTER_CUBIC);
                    resultSangre = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, INTER.CV_INTER_CUBIC);
                    resultAlergias = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, INTER.CV_INTER_CUBIC);
                    //Dibujar el cuadro para el rostro
                    currentFrame.Draw(f.rect, new Bgr(Color.LightGreen), 1);

                    if (trainingImages.ToArray().Length != 0)
                    {
                        //Clase para reconocimiento con el nùmero de imagenes
                        MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);

                        //Clase Eigen para reconocimiento de rostro
                        EigenObjectRecognizer recognizer = new EigenObjectRecognizer(trainingImages.ToArray(), labels.ToArray(), ref termCrit);
                        EigenObjectRecognizer recognizerCED = new EigenObjectRecognizer(trainingImages.ToArray(), labelsCed.ToArray(), ref termCrit);
                        EigenObjectRecognizer recognizerFN = new EigenObjectRecognizer(trainingImages.ToArray(), labelsFecha.ToArray(), ref termCrit);
                        EigenObjectRecognizer recognizerSG = new EigenObjectRecognizer(trainingImages.ToArray(), labelsSangre.ToArray(), ref termCrit);
                        EigenObjectRecognizer recognizerAL = new EigenObjectRecognizer(trainingImages.ToArray(), labelsAlergia.ToArray(), ref termCrit);
                        var fa = new Image<Gray, byte>[trainingImages.Count]; //currentFrame.Convert<Bitmap>();

                        name = recognizer.Recognize(result);
                        Cedula = recognizerCED.Recognize(resultCed);
                        Fecha_Nacimiento = recognizerFN.Recognize(resultFN);
                        Sangre = recognizerSG.Recognize(resultSangre);
                        Alergia = recognizerAL.Recognize(resultAlergias);
                        //Dibujar el nombre para cada rostro detectado y reconocido
                        currentFrame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.YellowGreen));
                        if (name == "")
                        {
                            currentFrame.Draw("Usuario Desconocido", ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.YellowGreen));
                        }
                    }

                    NamePersons[t - 1] = name;
                    CedulaPersons[t - 1] = Cedula;
                    Fecha_NaciPersons[t - 1] = Fecha_Nacimiento;
                    SangrePersons[t - 1] = Sangre;
                    AlergiaPersons[t - 1] = Alergia;
                    NamePersons.Add("");
                    CedulaPersons.Add("");
                    Fecha_NaciPersons.Add("");
                    SangrePersons.Add("");
                    AlergiaPersons.Add("");
                    //Establecer el nùmero de rostros detectados
                    lblNumeroDetect.Text = facesDetected[0].Length.ToString();
                    lblNadie.Text = name;
                    lblCedResultado.Text = Cedula;
                    lblFNResultado.Text = Fecha_Nacimiento;
                    lblSangreResultado.Text = Sangre;
                    lblAlergiaResultado.Text = Alergia;
                }
                t = 0;

                //Nombres concatenados de todos los rostros reconocidos
                for (int nnn = 0; nnn < facesDetected[0].Length; nnn++)
                {
                    names = names + NamePersons[nnn] + ", ";
                    Cedulas = Cedulas + CedulaPersons[nnn] + ", ";
                    Sangress = Sangress + SangrePersons[nnn] + ", ";
                    Alergiass = Alergiass + AlergiaPersons[nnn] + ", ";
                    Fecha_Nacimientos = Fecha_Nacimientos + Fecha_NaciPersons[nnn] + ", ";
                }

                //Mostrar los rostros procesados y reconocidos
                imageBoxFrameGrabber.Image = currentFrame;
                name = "";
                Cedula = "";
                Fecha_Nacimiento = "";
                Sangre = "";
                Alergia = "";

                //Borrar la lista de nombres            
                NamePersons.Clear();
                CedulaPersons.Clear();
                Fecha_NaciPersons.Clear();
                SangrePersons.Clear();
                AlergiaPersons.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Frm_Reconocimiento_Load(object sender, EventArgs e)
        {
            Reconocer();
            media.SoundLocation = "sounds/2.wav";
            media.Play();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                Desconectar();
                Registro re = new Registro();
                Bg fil = new Bg();
                fil.Show();
                re.ShowDialog();
                fil.Hide();
            }
            catch
            {

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //switch (button4.Text)
            //{
            //    case "Conectar":
            //        Reconocer();
            //        button4.Text = "Desconectar";
            //        button4.BackgroundStyle.SolidColor = Color.YellowGreen;
            //        button4.BorderStyle.SolidColor = Color.YellowGreen;
            //        button4.StateStyles.HoverStyle.BackgroundSolidColor = Color.YellowGreen;
            //        button4.StateStyles.HoverStyle.BorderSolidColor = Color.YellowGreen;
            //        break;
            //    case "Desconectar":
            //        Desconectar();
            //        break;
            //}
        }
        private void Desconectar()
        {
            Application.Idle -= new EventHandler(FrameGrabber);
            grabber.Dispose();
            imageBoxFrameGrabber.ImageLocation = "img/1.jpg";
            lblNadie.Text = string.Empty;
            lblNumeroDetect.Text = string.Empty;
            //button4.Text = "Conectar";
            //button4.BackgroundStyle.SolidColor = Color.FromArgb(192, 0, 0);
            //button4.BorderStyle.SolidColor= Color.FromArgb(192, 0, 0);
            //button4.StateStyles.HoverStyle.BackgroundSolidColor = Color.FromArgb(192, 0, 0);
            //button4.StateStyles.HoverStyle.BorderSolidColor = Color.FromArgb(192, 0, 0);
        }
    }
}

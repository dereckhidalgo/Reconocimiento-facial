using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reconocimiento_facial
{
    public class DataBase
    {
        private OleDbConnection conn;
        public string[] Name;
        public string[] Cedula;
        public string[] Sangre;
        public string[] Alergias;
        public string[] Fecha_Naci;
        private byte[] face;
        public List<byte[]> Face = new List<byte[]>();
        public int TotalUser;
        public DataBase()
        {
            conn = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = UsersFace.mdb");
            conn.Open();
        }
        public bool GuardarImagen(string Nombre, string Cedula, string Sangre, string Alergias, string Fecha_Nacimiento, byte[] abImagen)
        {
            conn.Open();
            OleDbCommand comm = new OleDbCommand("INSERT INTO UserFaces (Nombre,Cedula,Sangre,Alergias,Fecha_Nacimiento,Face) VALUES ('" + Nombre + "','" + Cedula + "','" + Sangre + "','" + Alergias + "','" + Fecha_Nacimiento + "',?)", conn);
            OleDbParameter parImagen = new OleDbParameter("@Face", OleDbType.VarBinary, abImagen.Length);
            parImagen.Value = abImagen;
            comm.Parameters.Add(parImagen);
            int iResultado = comm.ExecuteNonQuery();
            conn.Close();
            return Convert.ToBoolean(iResultado);
        }

        public DataTable ObtenerBytesImagen()
        {
            string sql = "SELECT IdImage,Nombre,Cedula,Sangre,Alergias,Fecha_Nacimiento,Face FROM UserFaces";
            OleDbDataAdapter adaptador = new OleDbDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            int cont = dt.Rows.Count;
            Name = new string[cont];
            Cedula = new string[cont];
            Sangre = new string[cont];
            Alergias = new string[cont];
            Fecha_Naci = new string[cont];

            for (int i = 0; i < cont; i++)
            {
                Name[i] = dt.Rows[i]["Nombre"].ToString();
                Cedula[i] = dt.Rows[i]["Cedula"].ToString();
                Sangre[i] = dt.Rows[i]["Sangre"].ToString();
                Alergias[i] = dt.Rows[i]["Alergias"].ToString();
                Fecha_Naci[i] = dt.Rows[i]["Fecha_Nacimiento"].ToString();
                face = (byte[])dt.Rows[i]["Face"];
                Face.Add(face);
            }
            TotalUser = dt.Rows.Count;
            conn.Close();
            return dt;
        }

        public void ConvertImgToBinary(string Nombre, string Cedula, string Sangre, string Alergias, string Fecha_Nacimiento, Image Img)
        {
            Bitmap bmp = new Bitmap(Img);
            MemoryStream MyStream = new MemoryStream();
            bmp.Save(MyStream, System.Drawing.Imaging.ImageFormat.Bmp);

            byte[] abImagen = MyStream.ToArray();
            GuardarImagen(Nombre, Cedula, Sangre, Alergias, Fecha_Nacimiento, abImagen);
        }

        public Image ConvertByteToImg(int con)
        {
            Image FetImg;
            byte[] img = Face[con];
            MemoryStream ms = new MemoryStream(img);
            FetImg = Image.FromStream(ms);
            ms.Close();
            return FetImg;

        }
    }
}

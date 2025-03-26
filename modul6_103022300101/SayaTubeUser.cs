using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpmodul6_103022300101;

namespace modul6_103022300101
{
    //Class SayaTubeUser
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadVideos;
        public string username;

        //Constructor SayaTubeUser
        public SayaTubeUser(string username)
        {
            Random ran = new Random(); //Generate random number
            this.id = ran.Next(1000, 9999); //Isi id dengan random number
            this.uploadVideos = []; //Inisialiassi List kosong
            this.username = username; //Isi Username dari parameter Constructor
        }
        
        //Class Untuk mengambil Video Cunt
        public int GetTotalVideoPlayCount()
        {
            int hasil = 0; //Inisialisasi variable hasil dengan nilai 0
            for (int i = 0; i < uploadVideos.Count; i++) //Perulangan untuk mencari judul dari 0 sampai akhir judul video
            {
                hasil += uploadVideos[i].getTotalCount(); //Menambahkan hasil dengan total penonton
            }
            return hasil; //Mengembalikan nilai hasil
        }

        public void addVideo(SayaTubeVideo video) //Class menambahkan video
        {
            uploadVideos.Add(video); //menambahkan video
        }

        public void printAllVideoPlayCount() //Menampilkan ke layar
        {
            Console.WriteLine($"User: {username}"); //Print username
            for (int i = 0; i < uploadVideos.Count; i++) //Perulangan untuk mendapatkan semua judul
            {
                Console.WriteLine($"Video {i} judul: {uploadVideos[i].getTitle()}"); //Menampilkan judul sesuai dengan index
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_103022300101
{
    class SayaTubeVideo
    {
        private int id; // ID unik untuk video
        private string title; //Judul Video
        private int playCount; //Jumlah pemutaran object
        Random ran = new Random(); //Generate angka acak

        public SayaTubeVideo(string title) //Constructor dari class SayaTubeVideo
        {
            this.id = ran.Next(1000, 9999); //Memasukkan angka acak ke id
            this.title = title; //Memasukkan nama lagu yang diambil dari construktor
            this.playCount = 0; //Inisialisasi Awal 0
        }
        
        //Menambahkan jumlah pendengar
        public void IncreasePlayCount(int count)
        {
            this.playCount += count; //Memasukkan jumlah pemutaran lagi yang didapat dari count
        }

        //Menampilkan detail lagu ke layar
        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID: {id}"); //Menampilkan ID
            Console.WriteLine($"Judul: {title}"); //Menampilkan judul lagu
            Console.WriteLine($"Jumlah diputar: {playCount}"); //Menampilkan berapa jumlah penayangan lagu
        }

        public int getTotalCount()
        {
            return this.playCount;
        }

        public String getTitle()
        {
            return this.title;
        }
    }
}
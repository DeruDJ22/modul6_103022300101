using System;
using tpmodul6_103022300101;

namespace modul6_103022300101
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaTubeUser user = new SayaTubeUser("DeruDJ");
            SayaTubeVideo video = new SayaTubeVideo("Review Film Detective Conan The Fist of Blue Saphire oleh DeruDJ");
            SayaTubeVideo video1 = new SayaTubeVideo("Review Film Kimi no Nawa oleh DeruDJ");
            SayaTubeVideo video2 = new SayaTubeVideo("Review Film Kimi ni Todoke oleh DeruDJ");
            SayaTubeVideo video3 = new SayaTubeVideo("Review Film Tenki no ko oleh DeruDJ");
            SayaTubeVideo video4 = new SayaTubeVideo("Review Film Suzume no Tojimari oleh DeruDJ");
            SayaTubeVideo video5 = new SayaTubeVideo("Review Film Kimi no Suizou wa Tabetai oleh DeruDJ");
            SayaTubeVideo video6 = new SayaTubeVideo("Review Film 5 Centimeter per second oleh DeruDJ");
            SayaTubeVideo video7 = new SayaTubeVideo("Review Film Tunnel to the Summer oleh DeruDJ");
            SayaTubeVideo video8 = new SayaTubeVideo("Review Film Naruto the Last oleh DeruDJ");
            SayaTubeVideo video9 = new SayaTubeVideo("Review Film Kuroko no Basuke the Movie: Last Game oleh DeruDJ");

            user.addVideo(video);
            user.addVideo(video1);
            user.addVideo(video2);
            user.addVideo(video3);
            user.addVideo(video4);
            user.addVideo(video5);
            user.addVideo(video6);
            user.addVideo(video7);
            user.addVideo(video8);
            user.addVideo(video9);

            user.printAllVideoPlayCount();
        }
    }
}
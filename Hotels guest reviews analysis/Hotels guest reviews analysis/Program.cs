using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotels_guest_reviews_analysis
{
    class Review
    {
        public int HotelName;
        public string Revieww;
    }
    class Score
    {
        public int HotelName;
        public int score;
    }
    class Program
    {

        static List<Score> Scores = new List<Score>();
        static void Main(string[] args)
        {
            string[] BadWords = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32 (Console.ReadLine());
            List<Review> Reviews = new List<Review>();
            for (int i = 0; i < n; i ++ )
            {
                int Hotel = Convert.ToInt32(Console.ReadLine());
                string r = Console.ReadLine();
               
                    Review rev = new Review();
                    rev.HotelName = Hotel ;
                    rev.Revieww = r;
                    Reviews.Add(rev);
                    AddHotelToScores(Hotel);
                
            }
            foreach (Review r in Reviews)
            {
                int BadW = FindArrayInString(r.Revieww, BadWords);
                IncreaseHotelScore(r.HotelName, BadW);
            }
            List<Score> OrderedScores = Scores.OrderByDescending(o => o.score).ToList();
            foreach (Score s in OrderedScores)
            {
                Console.Write(s.HotelName + " ");
            }
            Console.ReadLine();
        }
        public static  void  AddHotelToScores(int HotelName )
        {
            bool exist = false ;
            foreach (Score a in Scores)
            {
                if (HotelName == a.HotelName)
                {
                    exist = true;
                }
            }
            if (exist == false)
            {
                Score n = new Score();
                n.HotelName = HotelName;
                n.score = 0;
                Scores.Add(n);
            }
        }
        public static void IncreaseHotelScore(int HotelName, int Increase)
        {
            foreach (Score a in Scores)
            {
                if (HotelName == a.HotelName)
                {
                    a.score += Increase;
                }
            }
        }
        public static int FindArrayInString(string main, string[] Words)
        {
            int Count = 0;
            foreach (string word in Words)
            {
                if (main.Contains(word) != false)
                {
                    Count++;
                }
            }
            return Count;
        }
    }
}

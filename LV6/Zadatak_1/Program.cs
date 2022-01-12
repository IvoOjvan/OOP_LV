using System;
using System.Collections.Generic;

namespace Zadatak_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Post> Posts = new Dictionary<string, Post>();
            Posts.Add("Pero", new Post("Pero", "Msg1"));
            Posts.Add("Maja", new Post("Maja", "Msg2"));
            Posts.Add("Ivo", new Post("Ivo", "Msg3"));

            foreach(KeyValuePair<string, Post> post in Posts) 
            {
                //Console.WriteLine(post.ToString() + "\n");
                Post p = new Post(post.Value);
                Console.WriteLine(p + "\n");
            }
        }
    }
}

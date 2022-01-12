using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak_1
{
    class Post
    {
        #region Properties
        public string AccountName { get; private set; }
        public string Message { get; private set; }
        public List<string> Hashtags { get; private set; }
        public DateTime Posted { get; private set; }
        #endregion

        #region Constructors
        public Post(string accountName, string message) 
        {
            AccountName = accountName;
            Message = message;
            Hashtags = new List<string>();
            Posted = DateTime.Now;
        }

        public Post(Post post) 
        {
            this.AccountName = post.AccountName;
            this.Message = post.Message;

            foreach (string hashtag in post.Hashtags) 
            {
                this.Hashtags.Add(hashtag);
            }

            this.Posted = post.Posted;
        }
        #endregion

        #region Methods
        public void Tag(string tag) 
        {
            Hashtags.Add(tag);
        }

        public void Untag(string tag) 
        {
            for (int i = Hashtags.Count - 1; i >= 0; i--) 
            {
                if (Hashtags[i] == tag) 
                {
                    Hashtags.RemoveAt(i);
                }
            }
        }

        public override string ToString()
        {
            return $"Account: {AccountName}\nMessage: {Message}\nHashtags: {Hashtags}\nPosted: {Posted}";
        }
        #endregion
    }
}

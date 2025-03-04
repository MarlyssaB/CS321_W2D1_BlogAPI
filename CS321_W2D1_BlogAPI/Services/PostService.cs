﻿using System;
using System.Collections.Generic;
using System.Linq;
using CS321_W2D1_BlogAPI.Models;

namespace CS321_W2D1_BlogAPI.Services
{
    public class PostService : IPostService
    {
        // seed some initial Post data
        private List<Post> _posts = new List<Post>()
        {
            new Post
            {
                Id = 1,
                Title = "My first blog post",
                Body = "Blah blah blah"
            },
            new Post
            {
                Id = 2,
                Title = "My second blog post",
                Body = "Blah blah blah"
            }
        };
        // keep track of next id number
        private int _nextId = 3;

        public Post Add(Post post)
        {
            // assign an id (and then increment _nextId for next time)
            post.Id = _nextId++;
            // store in the list of Posts
            // CHECKTODO: add the new post to the list of posts (_posts)
            _posts.Add(post);
            // return the new Post with Id filled in
            return post;
        }

        public Post Get(int id)
        {
            // return the specified Post or null if not found
            // CHECKTODO: use FirstOrDefault() to find the Post by id in _posts and return it
            return _posts.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Post> GetAll()
        {
            return _posts;

            //Dictionary<int, string> post = new Dictionary<int, string>();
            //post.Add(1, "Post 1");
           // post.Add(2, "Post 2");
            //post.Add(3, "Post 3");
            //return post;
        }

        public Post Update(Post updatedPost)
        {
            // get the Post object in the current list with this id 
            // CHECKTODO: find the post to update in the list, using updatedPost.Id, and assign to currentPost
            var currentPost = _posts.FirstOrDefault(p => p.Id == updatedPost.Id);
            // return null if the Post to update isn't found
            if (currentPost == null) return null;

            // copy the property values from the updated post into the current post object
            // CHECKTODO: copy the values in updatedPost to the post you found in the list
            currentPost.Title = updatedPost.Title;
            currentPost.Body = updatedPost.Body;
            return currentPost;
        }

   
        public void Remove(Post post)
        {
            _posts.Remove(post);
            // CHECKTODO: remove the post from _posta

        }
    }
}

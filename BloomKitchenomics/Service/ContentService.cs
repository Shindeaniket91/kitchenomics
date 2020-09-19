using BloomKitchenomics.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BloomKitchenomics.Service
{
    public class ContentService
    {
        internal List<Content> GetContents()
        {
            List<Content> contents = new List<Content>
            {
                new Content { ContentTitle = "How to make a better kitchen", ContentType = "Lesson 1", IsVideo = true, ContentImage = "ArrangedDishes.png"},
                new Content { ContentTitle = "Forest Feast", ContentType = "Article", IsVideo = false, ContentImage = "ForestFeast.png", Pages= 123},
                new Content { ContentTitle = "How to make a better kitchen", ContentType = "Lesson 3", IsVideo = true, ContentImage = "ArrangedDishes.png"},
            };

            return contents;
        }
    }
}

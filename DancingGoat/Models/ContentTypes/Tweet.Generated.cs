// <auto-generated>
// This code was generated by a kontent-generators-net tool
// (see https://github.com/kontent-ai/model-generator-net).
//
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// For further modifications of the class, create a separate file with the partial class.
// </auto-generated>

using System;
using System.Collections.Generic;
using Kontent.Ai.Delivery.Abstractions;

namespace DancingGoat.Models
{
    public partial class Tweet
    {
        public const string Codename = "tweet";
        public const string DisplayOptionsCodename = "display_options";
        public const string ThemeCodename = "theme";
        public const string TweetLinkCodename = "tweet_link";

        public IEnumerable<IMultipleChoiceOption> DisplayOptions { get; set; }
        public IContentItemSystemAttributes System { get; set; }
        public IEnumerable<IMultipleChoiceOption> Theme { get; set; }
        public string TweetLink { get; set; }
    }
}
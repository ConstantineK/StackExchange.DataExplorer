﻿using System;

using StackExchange.DataExplorer.Helpers;

namespace StackExchange.DataExplorer.Models
{
    public class QuerySet
    {

        public int Id { get; set; }
        public int InitialRevisionId { get; set; }
        public int CurrentRevisionId { get; set; }
        public int? OwnerId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime LastActivity { get; set; }
        public int Votes { get; set; }
        public int Views { get; set; }

        public Revision InitialRevision 
        {
            get 
            {
                return Current.DB.Revisions.Get(this.InitialRevisionId);
            }
        }

        public Revision CurrentRevision
        {
            get
            {
                return Current.DB.Revisions.Get(this.CurrentRevisionId);
            }
        }
    }
}
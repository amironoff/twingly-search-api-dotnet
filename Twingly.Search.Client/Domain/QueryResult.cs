﻿using System.Collections.Generic;
using System.Xml.Serialization;

namespace Twingly.Search.Client.Domain
{
    /// <summary>
    /// Encapsulates results of a successfully executed <see cref="Query"/>
    /// </summary>
    [XmlRoot("twinglydata")]
    public class QueryResult
    {
        /// <summary>
        /// A collection of matching blog posts.
        /// </summary>
        [XmlElement("post")]
        public List<Post> Posts { get; set; }

        /// <summary>
        /// The number of matches returned during this particular request.
        /// </summary>
        [XmlAttribute("numberOfMatchesReturned")]
        public int NumberOfMatchesReturned { get; set; }

        /// <summary>
        /// The time it took to process the request on the server, in seconds.
        /// </summary>
        [XmlAttribute("secondsElapsed")]
        public double SecondsElapsed { get; set; }

        /// <summary>
        /// The total number of documents matching the query.
        /// </summary>
        [XmlAttribute("numberOfMatchesTotal")]
        public long NumberOfMatchesTotal { get; set; }

        [XmlAttribute("incompleteResult")]
        public bool IncompleteResult { get; set; }

        /// <summary>
        /// Returns a value indicating whether there are any more results in the result set.
        /// </summary>
        public bool HasNoMoreResults => NumberOfMatchesReturned == NumberOfMatchesTotal;
    }
}

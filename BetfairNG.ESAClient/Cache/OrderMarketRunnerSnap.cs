﻿using Betfair.ESASwagger.Model;
using System.Collections.Generic;

namespace Betfair.ESAClient.Cache
{
    /// <summary>
    /// Thread safe atomic snapshot of a runner.
    /// Reference only changes if the snapshot changes:
    /// i.e. if snap1 == snap2 then they are the same.
    /// (same is true for sub-objects)
    /// </summary>
    public class OrderMarketRunnerSnap
    {
        /// <summary>
        /// Price point aggregations of matches
        /// </summary>
        public IList<PriceSize> MatchedBack { get; internal set; }

        /// <summary>
        /// Price point aggregations of matches
        /// </summary>
        public IList<PriceSize> MatchedLay { get; internal set; }

        /// <summary>
        /// Runner id.
        /// </summary>
        public RunnerId RunnerId { get; internal set; }

        /// <summary>
        /// Orders that are unmatched (this includes the transiont to Execution Complete; but this
        /// is not the case on an initial image).
        /// </summary>
        public Dictionary<string, Order> UnmatchedOrders { get; internal set; }

        public override string ToString()
        {
            return "OrderMarketRunnerSnap{" +
                "RunnerId=" + RunnerId +
                ", UnmatchedOrders=" + string.Join(", ", UnmatchedOrders.Values) +
                ", MatchedLay=" + string.Join(", ", MatchedLay) +
                ", MatchedBack=" + string.Join(", ", MatchedBack) +
                "}";
        }
    }
}
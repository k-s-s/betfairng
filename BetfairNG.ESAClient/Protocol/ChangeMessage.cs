﻿using System;
using System.Collections.Generic;

namespace Betfair.ESAClient.Protocol
{
    /// <summary>
    /// Adapted version of a change message.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ChangeMessage<T>
    {
        private readonly DateTime _arrivalTime;

        public ChangeMessage()
        {
            _arrivalTime = DateTime.UtcNow;
        }

        public DateTime ArrivalTime
        {
            get
            {
                return _arrivalTime;
            }
        }

        public ChangeType ChangeType { get; set; }

        public string Clk { get; set; }

        public long? ConflateMs { get; set; }

        public long? HeartbeatMs { get; set; }

        public int Id { get; set; }

        public string InitialClk { get; set; }

        /// <summary>
        /// End of subscription / resubscription
        /// </summary>
        public bool IsEndOfRecovery
        {
            get
            {
                return (ChangeType == ChangeType.SUB_IMAGE || ChangeType == ChangeType.RESUB_DELTA) &&
                    (SegmentType == SegmentType.NONE || SegmentType == SegmentType.SEG_END);
            }
        }

        /// <summary>
        /// Start of new subscription (not resubscription)
        /// </summary>
        public bool IsStartOfNewSubscription
        {
            get
            {
                return ChangeType == ChangeType.SUB_IMAGE &&
                    (SegmentType == SegmentType.NONE || SegmentType == SegmentType.SEG_START);
            }
        }

        /// <summary>
        /// Start of subscription / resubscription
        /// </summary>
        public bool IsStartOfRecovery
        {
            get
            {
                return (ChangeType == ChangeType.SUB_IMAGE || ChangeType == ChangeType.RESUB_DELTA) &&
                    (SegmentType == SegmentType.NONE || SegmentType == SegmentType.SEG_START);
            }
        }

        public List<T> Items { get; set; }

        public long? Pt { get; set; }

        public SegmentType SegmentType { get; set; }
    }
}
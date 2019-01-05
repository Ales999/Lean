/**/
using System;
using System.Collections.Generic;
using QuantConnect.Configuration;
using QuantConnect.Interfaces;
using QuantConnect.Packets;
using QuantConnect.Util;
using QuantConnect.Logging;
using Newtonsoft.Json;


namespace QuantConnect.Brokerages.MCX
{

    /// <summary>
    /// Factory type for the <see cref="MoexBrokerage"/>
    /// </summary>
    public class MoexBrokerageFactory : BrokerageFactory
    {
        /// <summary>
        /// MOEX Broker Factory
        /// </summary>
        public MoexBrokerageFactory() : base(typeof(MoexBrokerage))
        {
        }

        /// <summary>
        /// Moex Factory Dispose
        /// </summary>
        public override void Dispose()
        {
            // TODO: Add STOP MOEX Connector;
        }

        public override Dictionary<string, string> BrokerageData
        {
            get
            {
                var data = new Dictionary<string, string>();
                // TODO: Add data for configure MOEX
                return data;
            }
        }
        /// <summary>
        /// Return Moex Brokerable Model
        /// </summary>
        public override IBrokerageModel BrokerageModel {
            get
            {
                return new MoexBrokerableModel();
            }
         }

       /// <summary>
       /// Create Moex brokerage
       /// </summary>
       /// <param name="job"></param>
       /// <param name="algorithm"></param>
       /// <returns></returns>
        public override IBrokerage CreateBrokerage(LiveNodePacket job, IAlgorithm algorithm)
        {
           // throw new NotImplementedException();
            var errors = new List<string>();
            // ....
            var mcx = new MoexBrokerage(algorithm, algorithm.Transactions, algorithm.Portfolio);
            Composer.Instance.AddPart<IDataQueueHandler>(mcx);

            return mcx;
        }
    }
}

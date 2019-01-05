using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using QuantConnect.Configuration;
using QuantConnect.Data;
using QuantConnect.Data.Market;
using QuantConnect.Interfaces;
using QuantConnect.Logging;
using QuantConnect.Orders;
using QuantConnect.Packets;
using QuantConnect.Securities;
using QuantConnect.Util;
using Order = QuantConnect.Orders.Order;
//using MCX = QuantConnect.Brokerages.MCX.Client;
using IBApi;
using NodaTime;
using QuantConnect.Orders.Fees;
using QuantConnect.Orders.TimeInForces;
using Bar = QuantConnect.Data.Market.Bar;
using HistoryRequest = QuantConnect.Data.HistoryRequest;


namespace QuantConnect.Brokerages.MCX
{
    /// <summary>
    /// MOEX Brokerable
    /// </summary>
    [BrokerageFactory(typeof(MoexBrokerageFactory))]
    public sealed class MoexBrokerage : Brokerage, IDataQueueHandler, IDataQueueUniverseProvider
    {
        private readonly IAlgorithm _algorithm;
        private readonly IOrderProvider _orderProvider;
        private readonly ISecurityProvider _securityProvider;

        public MoexBrokerage(string name) : base(name)
        {
        }
        /// <summary>
        /// MOEX ctor
        /// </summary>
        /// <param name="algorithm"></param>
        /// <param name="orderProvider"></param>
        /// <param name="securityProvider"></param>
        public MoexBrokerage(IAlgorithm algorithm, IOrderProvider orderProvider, ISecurityProvider securityProvider) : base("MOEX Brokerable")
        {
            _algorithm = algorithm;
            _orderProvider = orderProvider;
            _securityProvider = securityProvider;

        }

        public override bool IsConnected { get; }

        public override List<Order> GetOpenOrders()
        {
            throw new NotImplementedException();
        }

        public override List<Holding> GetAccountHoldings()
        {
            throw new NotImplementedException();
        }

        public override List<CashAmount> GetCashBalance()
        {
            throw new NotImplementedException();
        }

        public override bool PlaceOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public override bool UpdateOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public override bool CancelOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public override void Connect()
        {
            throw new NotImplementedException();
        }

        public override void Disconnect()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BaseData> GetNextTicks()
        {
            throw new NotImplementedException();
        }

        public void Subscribe(LiveNodePacket job, IEnumerable<Symbol> symbols)
        {
            throw new NotImplementedException();
        }

        public void Unsubscribe(LiveNodePacket job, IEnumerable<Symbol> symbols)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Symbol> LookupSymbols(string lookupName, SecurityType securityType, string securityCurrency = null,
            string securityExchange = null)
        {
            throw new NotImplementedException();
        }
    }
}

/**/
using System;
using System.Collections.Generic;
using System.Linq;
using QuantConnect.Orders;
using QuantConnect.Orders.Fees;
using QuantConnect.Orders.TimeInForces;
using QuantConnect.Securities;


namespace QuantConnect.Brokerages
{
    /// <summary>
    /// Model for Moex
    /// </summary>
    public class MoexBrokerableModel : DefaultBrokerageModel
    {
        /// <summary>
        /// Moex Model ctor
        /// </summary>
        /// <param name="accountType"></param>
        public MoexBrokerableModel(AccountType accountType = AccountType.Margin) : base(accountType)
        {

        }
    }
}

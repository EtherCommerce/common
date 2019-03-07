namespace EtherCommerce.Common.Models
{
    public class Currency : ContentLifeTimeBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }


        public CurrencyRoundingRule RoundingRule { get; set; }
        public int RoundNumDecimals { get; set; }
        public bool RoundOrderItemsEnabled { get; set; }
        public bool RoundOrderTotalEnabled { get; set; }
    }


    public enum CurrencyRoundingRule
    {
        /// <summary>
        /// E.g. denomination 0.05: 0.125 will round to 0.10
        /// </summary>
        RoundMidpointDown = 0,

        /// <summary>
        /// E.g. denomination 0.05: 0.125 will round to 0.15
        /// </summary>
        RoundMidpointUp,

        /// <summary>
        /// E.g. denomination 0.05: 0.14 will round to 0.10
        /// </summary>
        AlwaysRoundDown,

        /// <summary>
        /// E.g. denomination 0.05: 0.16 will round to 0.20
        /// </summary>
        AlwaysRoundUp
    }
}

﻿namespace Lykke.Service.Dash.Api.Core.Domain.InsightClient
{
    public class Tx
    {
        public decimal Fees { get; set; }
        public int Confirmations { get; set; }
        public int BlockHeight { get; set; }
        public bool TxLock { get; set; }
        public TxVin[] Vin { get; set; }
        public TxVout[] Vout { get; set; }
    }

    public class TxVin
    {
        public string Txid { get; set; }
        public string Addr { get; set; }
        public decimal Value { get; set; }
    }

    public class TxVout
    {
        public string Txid { get; set; }
        public ScriptPubKey ScriptPubKey { get; set; }
        public decimal Value { get; set; }
    }

    public class ScriptPubKey
    {
        public string[] Addresses { get; set; }
    }
}

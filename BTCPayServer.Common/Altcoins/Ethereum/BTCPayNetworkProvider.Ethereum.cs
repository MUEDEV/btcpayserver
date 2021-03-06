﻿#if ALTCOINS
using NBitcoin;

namespace BTCPayServer
{
    public partial class BTCPayNetworkProvider
    {
        public void InitEthereum()
        {
            Add(new EthereumBTCPayNetwork()
            {
                CryptoCode = "ETH",
                DisplayName = "Ethereum",
                DefaultRateRules = new[] {"ETH_X = ETH_BTC * BTC_X", "ETH_BTC = kraken(ETH_BTC)"},
                BlockExplorerLink =
                    NetworkType == NetworkType.Mainnet
                        ? "https://etherscan.io/address/{0}"
                        : "https://ropsten.etherscan.io/address/{0}",
                CryptoImagePath = "/imlegacy/eth.png",
                ShowSyncSummary = true,
                CoinType = NetworkType == NetworkType.Mainnet? 60 : 1,
                ChainId = NetworkType == NetworkType.Mainnet ? 1 : 3,
                Divisibility = 18,
            });
        }
        
        public void InitERC20()
        {
            if (NetworkType != NetworkType.Mainnet)
            {
                Add(new ERC20BTCPayNetwork()
                {
                    CryptoCode = "wMUE",
                    DisplayName = "Wrapped MonetaryUnit",
                    DefaultRateRules = new[]
                    {
                                "MUE_X = MUE_BTC * BTC_X",
                                "MUE_BTC = bittrex(MUE_BTC)"
                    },
                    BlockExplorerLink = "https://ropsten.etherscan.io/address/{0}#tokentxns",
                    ShowSyncSummary = false,
                    CoinType =  1,
                    ChainId =  3,
                    //use https://erc20faucet.com for testnet
                    SmartContractAddress = "0xFab46E002BbF0b4509813474841E0716E6730136",
                    Divisibility = 18,
                    CryptoImagePath = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAQAAAC1HAwCAAAAC0lEQVR42mNkYAAAAAYAAjCB0C8AAAAASUVORK5CYII=",
                });
            }
            else
            {
                Add(new ERC20BTCPayNetwork()
                {
                    CryptoCode = "FAU",
                    DisplayName = "Faucet Token",
                    DefaultRateRules = new[]
                    {
                        "FAU_X = FAU_BTC * BTC_X",
                        "FAU_BTC = 0.01",
                    },
                    BlockExplorerLink = "https://ropsten.etherscan.io/address/{0}#tokentxns",
                    ShowSyncSummary = false,
                    CoinType =  1,
                    ChainId =  3,
                    //use https://erc20faucet.com for testnet
                    SmartContractAddress = "0xFab46E002BbF0b4509813474841E0716E6730136",
                    Divisibility = 18,
                    CryptoImagePath = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAQAAAC1HAwCAAAAC0lEQVR42mNkYAAAAAYAAjCB0C8AAAAASUVORK5CYII=",
                });
            }
            
        }
    }
}
#endif

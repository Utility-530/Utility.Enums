namespace Utility.Enums
{
    public enum AssetType
    {
        // --- Real Assets ---
        Property,           // e.g. real estate, land, buildings

        Vehicle,            // cars, boats, aircraft, etc.
        Equipment,          // machinery, computers, office equipment
        PreciousMetals,     // gold, silver, platinum, etc.
        Collectible,        // art, antiques, wine, rare items
        Inventory,          // goods held for sale

        // --- Financial Assets ---
        Savings,            // bank accounts, cash equivalents

        Investment,         // generic category (e.g. stocks, bonds, funds)
        Stock,              // individual shares
        Bond,               // government or corporate bonds
        MutualFund,         // pooled investment fund
        ETF,                // exchange-traded fund
        Cryptocurrency,     // digital assets (e.g. Bitcoin, Ethereum)
        Pension,            // retirement funds, 401(k), superannuation
        InsurancePolicy,    // life or investment-linked insurance
        Derivative,         // options, futures, swaps

        // --- Intangible Assets ---
        IntellectualProperty, // patents, trademarks, copyrights

        BrandValue,           // goodwill, brand recognition
        SoftwareLicense,      // owned software or rights to use it
        DomainName,           // valuable internet domains

        // --- Business & Equity ---
        BusinessOwnership,   // private company shares, partnerships

        EquityStake,         // minority/majority ownership in a business
        Franchise,           // franchise rights or territories

        // --- Miscellaneous / General ---
        Cash,                // physical cash

        Receivable,          // money owed (accounts receivable, loans)
        Commodity,           // oil, natural gas, agricultural products
        Other                // catch-all for anything not listed
    }
}

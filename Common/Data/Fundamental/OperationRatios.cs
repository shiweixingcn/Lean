/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

//------------------------------------------------------------------------------
// This code was generated by a tool.
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;

namespace QuantConnect.Data.Fundamental
{
	/// <summary>
	/// Definition of the OperationRatios class
	/// </summary>
	public class OperationRatios
	{
		/// <summary>
		/// The growth in the company’s revenue on a percentage basis. Morningstar calculates the growth percentage based on the
		/// underlying revenue data reported in the Income Statement within the company filings or reports.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 10001
		/// </remarks>
		public RevenueGrowth RevenueGrowth { get; set; }

		/// <summary>
		/// The growth in the company’s operating income on a percentage basis. Morningstar calculates the growth percentage based on the
		/// underlying operating income data reported in the Income Statement within the company filings or reports.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 10002
		/// </remarks>
		public OperationIncomeGrowth OperationIncomeGrowth { get; set; }

		/// <summary>
		/// The growth in the company’s net income on a percentage basis. Morningstar calculates the growth percentage based on the
		/// underlying net income data reported in the Income Statement within the company filings or reports.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 10003
		/// </remarks>
		public NetIncomeGrowth NetIncomeGrowth { get; set; }

		/// <summary>
		/// The growth in the company’s net income from continuing operations on a percentage basis. Morningstar calculates the growth
		/// percentage based on the underlying net income from continuing operations data reported in the Income Statement within the
		/// company filings or reports. This figure represents the rate of net income growth for parts of the business that will continue to
		/// generate revenue in the future.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 10004
		/// </remarks>
		public NetIncomeContOpsGrowth NetIncomeContOpsGrowth { get; set; }

		/// <summary>
		/// The growth in the company’s cash flow from operations on a percentage basis. Morningstar calculates the growth percentage
		/// based on the underlying cash flow from operations data reported in the Cash Flow Statement within the company filings or reports.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 10005
		/// </remarks>
		public CFOGrowth3MonthAvg CFOGrowth3MonthAvg { get; set; }

		/// <summary>
		/// The growth in the company’s free cash flow on a percentage basis. Morningstar calculates the growth percentage based on the
		/// underlying cash flow from operations and capital expenditures data reported in the Cash Flow Statement within the company filings
		/// or reports:   Free Cash Flow = Cash flow from operations – Capital Expenditures.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 10006
		/// </remarks>
		public FCFGrowth3MonthAvg FCFGrowth3MonthAvg { get; set; }

		/// <summary>
		/// The growth in the company’s operating revenue on a percentage basis. Morningstar calculates the growth percentage based on
		/// the underlying operating revenue data reported in the Income Statement within the company filings or reports.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 10007
		/// </remarks>
		public OperationRevenueGrowth3MonthAvg OperationRevenueGrowth3MonthAvg { get; set; }

		/// <summary>
		/// Refers to the ratio of gross profit to revenue. Morningstar calculates the ratio by using the underlying data reported in the company
		/// filings or reports:   (Revenue – Cost of Goods Sold) / Revenue.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 11001
		/// </remarks>
		public GrossMargin GrossMargin { get; set; }

		/// <summary>
		/// Refers to the ratio of operating income to revenue. Morningstar calculates the ratio by using the underlying data reported in the
		/// company filings or reports:   Operating Income / Revenue.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 11002
		/// </remarks>
		public OperationMargin OperationMargin { get; set; }

		/// <summary>
		/// Refers to the ratio of pretax income to revenue. Morningstar calculates the ratio by using the underlying data reported in the
		/// company filings or reports:   Pretax Income / Revenue.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 11003
		/// </remarks>
		public PretaxMargin PretaxMargin { get; set; }

		/// <summary>
		/// Refers to the ratio of net income to revenue. Morningstar calculates the ratio by using the underlying data reported in the company
		/// filings or reports:   Net Income / Revenue.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 11004
		/// </remarks>
		public NetMargin NetMargin { get; set; }

		/// <summary>
		/// Refers to the ratio of tax provision to pretax income. Morningstar calculates the ratio by using the underlying data reported in the
		/// company filings or reports:   Tax Provision / Pretax Income.
		/// [Note: Valid only when positive pretax income, and  positive tax expense (not tax benefit)]
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 11005
		/// </remarks>
		public TaxRate TaxRate { get; set; }

		/// <summary>
		/// Refers to the ratio of earnings before interest and taxes to revenue. Morningstar calculates the ratio by using the underlying data
		/// reported in the company filings or reports:   EBIT / Revenue.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 11006
		/// </remarks>
		public EBITMargin EBITMargin { get; set; }

		/// <summary>
		/// Refers to the ratio of earnings before interest, taxes and depreciation and amortization to revenue. Morningstar calculates the ratio
		/// by using the underlying data reported in the company filings or reports:   EBITDA / Revenue.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 11007
		/// </remarks>
		public EBITDAMargin EBITDAMargin { get; set; }

		/// <summary>
		/// Refers to the ratio of Revenue to Employees. Morningstar calculates the ratio by using the underlying data reported in the company
		/// filings or reports:     Revenue / Employee Number.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 11008
		/// </remarks>
		public SalesPerEmployee SalesPerEmployee { get; set; }

		/// <summary>
		/// Refers to the ratio of Current Assets to Current Liabilities. Morningstar calculates the ratio by using the underlying data reported in
		/// the Balance Sheet within the company filings or reports:     Current Assets / Current Liabilities.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 11009
		/// </remarks>
		public CurrentRatio CurrentRatio { get; set; }

		/// <summary>
		/// Refers to the ratio of liquid assets to Current Liabilities. Morningstar calculates the ratio by using the underlying data reported in the
		/// Balance Sheet within the company filings or reports:    ( Cash, Cash Equivalents, and ShortTerm Investments + Receivables ) /
		/// Current Liabilities.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 11010
		/// </remarks>
		public QuickRatio QuickRatio { get; set; }

		/// <summary>
		/// Refers to the ratio of Long Term Debt to Total Capital. Morningstar calculates the ratio by using the underlying data reported in the
		/// Balance Sheet within the company filings or reports:    Long-Term Debt And Capital Lease Obligation / (Long-Term Debt And Capital
		/// Lease Obligation + Total Shareholder’s Equity)
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 11011
		/// </remarks>
		public LongTermDebtTotalCapitalRatio LongTermDebtTotalCapitalRatio { get; set; }

		/// <summary>
		/// Refers to the ratio of EBIT to Interest Expense. Morningstar calculates the ratio by using the underlying data reported in the Income
		/// Statement within the company filings or reports:    EBIT / Interest Expense.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 11012
		/// </remarks>
		public InterestCoverage InterestCoverage { get; set; }

		/// <summary>
		/// Refers to the ratio of Long Term Debt to Common Equity. Morningstar calculates the ratio by using the underlying data reported in
		/// the Balance Sheet within the company filings or reports:    Long-Term Debt And Capital Lease Obligation / Common Equity.
		/// [Note: Common Equity = Total Shareholder’s Equity – Preferred Stock]
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 11013
		/// </remarks>
		public LongTermDebtEquityRatio LongTermDebtEquityRatio { get; set; }

		/// <summary>
		/// Refers to the ratio of Total Assets to Common Equity. Morningstar calculates the ratio by using the underlying data reported in the
		/// Balance Sheet within the company filings or reports:    Total Assets / Common Equity.   [Note: Common Equity = Total
		/// Shareholder’s Equity – Preferred Stock]
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 11014
		/// </remarks>
		public FinancialLeverage FinancialLeverage { get; set; }

		/// <summary>
		/// Refers to the ratio of Current Debt and Long Term Debt to Common Equity. Morningstar calculates the ratio by using the underlying
		/// data reported in the Balance Sheet within the company filings or reports:    (Current Debt And Current Capital Lease Obligation +
		/// Long-Term Debt And Long-Term Capital Lease Obligation / Common Equity.   [Note: Common Equity = Total Shareholder’s Equity –
		/// Preferred Stock]
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 11015
		/// </remarks>
		public TotalDebtEquityRatio TotalDebtEquityRatio { get; set; }

		/// <summary>
		/// Normalized Income / Total Revenue. A measure of profitability of the company calculated by finding Normalized Net Profit as a
		/// percentage of Total Revenues.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 11016
		/// </remarks>
		public NormalizedNetProfitMargin NormalizedNetProfitMargin { get; set; }

		/// <summary>
		/// 365 / Receivable Turnover
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12001
		/// </remarks>
		public DaysInSales DaysInSales { get; set; }

		/// <summary>
		/// 365 / Inventory turnover
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12002
		/// </remarks>
		public DaysInInventory DaysInInventory { get; set; }

		/// <summary>
		/// 365 / Payable turnover
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12003
		/// </remarks>
		public DaysInPayment DaysInPayment { get; set; }

		/// <summary>
		/// Days In Inventory + Days In Sales – Days In Payment
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12004
		/// </remarks>
		public CashConversionCycle CashConversionCycle { get; set; }

		/// <summary>
		/// Revenue / Average Accounts Receivables
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12005
		/// </remarks>
		public ReceivableTurnover ReceivableTurnover { get; set; }

		/// <summary>
		/// Cost Of Goods Sold / Average Inventory
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12006
		/// </remarks>
		public InventoryTurnover InventoryTurnover { get; set; }

		/// <summary>
		/// Cost of Goods Sold / Average Accounts Payables
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12007
		/// </remarks>
		public PaymentTurnover PaymentTurnover { get; set; }

		/// <summary>
		/// Revenue / Average PP&amp;E
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12008
		/// </remarks>
		public FixAssetsTuronver FixAssetsTuronver { get; set; }

		/// <summary>
		/// Revenue / Average Total Assets
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12009
		/// </remarks>
		public AssetsTurnover AssetsTurnover { get; set; }

		/// <summary>
		/// Net Income / Average Total Common Equity
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12010
		/// </remarks>
		public ROE ROE { get; set; }

		/// <summary>
		/// Net Income / Average Total Assets
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12011
		/// </remarks>
		public ROA ROA { get; set; }

		/// <summary>
		/// Net Income / (Total Equity + Long-term Debt and Capital Lease Obligation + Short-term Debt and Capital Lease Obligation)
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12012
		/// </remarks>
		public ROIC ROIC { get; set; }

		/// <summary>
		/// Free Cash flow / Revenue
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12013
		/// </remarks>
		public FCFSalesRatio FCFSalesRatio { get; set; }

		/// <summary>
		/// Free Cash Flow / Net Income
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12014
		/// </remarks>
		public FCFNetIncomeRatio FCFNetIncomeRatio { get; set; }

		/// <summary>
		/// Capital Expenditure / Revenue
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12015
		/// </remarks>
		public CapExSalesRatio CapExSalesRatio { get; set; }

		/// <summary>
		/// This is a leverage ratio used to determine how much debt (a sum of long term and current portion of debt) a company has on its
		/// balance sheet relative to total assets. This ratio examines the percent of the company that is financed by debt.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12016
		/// </remarks>
		public DebttoAssets DebttoAssets { get; set; }

		/// <summary>
		/// This is a financial ratio of common stock equity to total assets that indicates the relative proportion of equity used to finance a
		/// company's assets.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12017
		/// </remarks>
		public CommonEquityToAssets CommonEquityToAssets { get; set; }

		/// <summary>
		/// This is the compound annual growth rate of the company's capital spending over the last 5 years. Capital Spending is the sum of
		/// the Capital Expenditure items found in the Statement of Cash Flows.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12018
		/// </remarks>
		public CapitalExpenditureAnnual5YrGrowth CapitalExpenditureAnnual5YrGrowth { get; set; }

		/// <summary>
		/// This is the compound annual growth rate of the company's Gross Profit over the last 5 years.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12019
		/// </remarks>
		public GrossProfitAnnual5YrGrowth GrossProfitAnnual5YrGrowth { get; set; }

		/// <summary>
		/// This is the simple average of the company's Annual Gross Margin over the last 5 years. Gross Margin is Total Revenue minus Cost
		/// of Goods Sold divided by Total Revenue and is expressed as a percentage.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12020
		/// </remarks>
		public GrossMargin5YrAvg GrossMargin5YrAvg { get; set; }

		/// <summary>
		/// This is the simple average of the company's Annual Post Tax Margin over the last 5 years. Post tax margin is Post tax divided by
		/// total revenue for the same period.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12021
		/// </remarks>
		public PostTaxMargin5YrAvg PostTaxMargin5YrAvg { get; set; }

		/// <summary>
		/// This is the simple average of the company's Annual Pre Tax Margin over the last 5 years. Pre tax margin is Pre tax divided by total
		/// revenue for the same period.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12022
		/// </remarks>
		public PreTaxMargin5YrAvg PreTaxMargin5YrAvg { get; set; }

		/// <summary>
		/// This is the simple average of the company's Annual Net Profit Margin over the last 5 years. Net profit margin is post tax income
		/// divided by total revenue for the same period.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12023
		/// </remarks>
		public ProfitMargin5YrAvg ProfitMargin5YrAvg { get; set; }

		/// <summary>
		/// This is the simple average of the company's ROE over the last 5 years. Return on equity reveals how much profit a company has
		/// earned in comparison to the total amount of shareholder equity found on the balance sheet.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12024
		/// </remarks>
		public ROE5YrAvg ROE5YrAvg { get; set; }

		/// <summary>
		/// This is the simple average of the company's ROA over the last 5 years. Return on asset is calculated by dividing a company's annual
		/// earnings by its average total assets.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12025
		/// </remarks>
		public ROA5YrAvg ROA5YrAvg { get; set; }

		/// <summary>
		/// This is the simple average of the company's ROIC over the last 5 years. Return on invested capital is calculated by taking net
		/// operating profit after taxes and dividends and dividing by the total amount of capital invested and expressing the result as a
		/// percentage.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12026
		/// </remarks>
		public AVG5YrsROIC AVG5YrsROIC { get; set; }

		/// <summary>
		/// [Normalized Income + (Interest Expense * (1-Tax Rate))]  / Invested Capital
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12027
		/// </remarks>
		public NormalizedROIC NormalizedROIC { get; set; }

		/// <summary>
		/// The five-year growth rate of operating revenue, calculated using regression analysis.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12028
		/// </remarks>
		public RegressionGrowthOperatingRevenue5Years RegressionGrowthOperatingRevenue5Years { get; set; }

		/// <summary>
		/// Creates an instance of the OperationRatios class
		/// </summary>
		public OperationRatios()
		{
			RevenueGrowth = new RevenueGrowth();
			OperationIncomeGrowth = new OperationIncomeGrowth();
			NetIncomeGrowth = new NetIncomeGrowth();
			NetIncomeContOpsGrowth = new NetIncomeContOpsGrowth();
			CFOGrowth3MonthAvg = new CFOGrowth3MonthAvg();
			FCFGrowth3MonthAvg = new FCFGrowth3MonthAvg();
			OperationRevenueGrowth3MonthAvg = new OperationRevenueGrowth3MonthAvg();
			GrossMargin = new GrossMargin();
			OperationMargin = new OperationMargin();
			PretaxMargin = new PretaxMargin();
			NetMargin = new NetMargin();
			TaxRate = new TaxRate();
			EBITMargin = new EBITMargin();
			EBITDAMargin = new EBITDAMargin();
			SalesPerEmployee = new SalesPerEmployee();
			CurrentRatio = new CurrentRatio();
			QuickRatio = new QuickRatio();
			LongTermDebtTotalCapitalRatio = new LongTermDebtTotalCapitalRatio();
			InterestCoverage = new InterestCoverage();
			LongTermDebtEquityRatio = new LongTermDebtEquityRatio();
			FinancialLeverage = new FinancialLeverage();
			TotalDebtEquityRatio = new TotalDebtEquityRatio();
			NormalizedNetProfitMargin = new NormalizedNetProfitMargin();
			DaysInSales = new DaysInSales();
			DaysInInventory = new DaysInInventory();
			DaysInPayment = new DaysInPayment();
			CashConversionCycle = new CashConversionCycle();
			ReceivableTurnover = new ReceivableTurnover();
			InventoryTurnover = new InventoryTurnover();
			PaymentTurnover = new PaymentTurnover();
			FixAssetsTuronver = new FixAssetsTuronver();
			AssetsTurnover = new AssetsTurnover();
			ROE = new ROE();
			ROA = new ROA();
			ROIC = new ROIC();
			FCFSalesRatio = new FCFSalesRatio();
			FCFNetIncomeRatio = new FCFNetIncomeRatio();
			CapExSalesRatio = new CapExSalesRatio();
			DebttoAssets = new DebttoAssets();
			CommonEquityToAssets = new CommonEquityToAssets();
			CapitalExpenditureAnnual5YrGrowth = new CapitalExpenditureAnnual5YrGrowth();
			GrossProfitAnnual5YrGrowth = new GrossProfitAnnual5YrGrowth();
			GrossMargin5YrAvg = new GrossMargin5YrAvg();
			PostTaxMargin5YrAvg = new PostTaxMargin5YrAvg();
			PreTaxMargin5YrAvg = new PreTaxMargin5YrAvg();
			ProfitMargin5YrAvg = new ProfitMargin5YrAvg();
			ROE5YrAvg = new ROE5YrAvg();
			ROA5YrAvg = new ROA5YrAvg();
			AVG5YrsROIC = new AVG5YrsROIC();
			NormalizedROIC = new NormalizedROIC();
			RegressionGrowthOperatingRevenue5Years = new RegressionGrowthOperatingRevenue5Years();
		}
	}
}

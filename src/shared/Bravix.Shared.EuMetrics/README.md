# EU Accounting Directive 2013/34/EU Metrics Catalog

This document describes each metric with a human-readable name and its dot-separated key. Use these keys as stable identifiers in code/DB.

## Framework

### Size Thresholds  
***Description***: Thresholds and flags defining entity size categories per Article 3.  
***Key***: framework.size_thresholds

- #### **Size of Assets**  
  ***Description***: Total assets figure used for size classification thresholds.  
  ***Key***: framework.size_thresholds.size_assets

- #### **Net Turnover**  
  ***Description***: Net turnover used for size classification thresholds.  
  ***Key***: framework.size_thresholds.size_net_turnover

- #### **Average Number of Employees**  
  ***Description***: Average number of employees during the financial year for size classification.  
  ***Key***: framework.size_thresholds.size_employees_average

- #### **Threshold — Micro: Assets**  
  ***Description***: Asset threshold for micro-undertaking classification.  
  ***Key***: framework.size_thresholds.threshold_micro_assets

- #### **Threshold — Micro: Net Turnover**  
  ***Description***: Net turnover threshold for micro-undertaking classification.  
  ***Key***: framework.size_thresholds.threshold_micro_net_turnover

- #### **Threshold — Micro: Employees**  
  ***Description***: Employee threshold for micro-undertaking classification.  
  ***Key***: framework.size_thresholds.threshold_micro_employees

- #### **Threshold — Small: Assets**  
  ***Description***: Asset threshold for small undertaking classification.  
  ***Key***: framework.size_thresholds.threshold_small_assets

- #### **Threshold — Small: Net Turnover**  
  ***Description***: Net turnover threshold for small undertaking classification.  
  ***Key***: framework.size_thresholds.threshold_small_net_turnover

- #### **Threshold — Small: Employees**  
  ***Description***: Employee threshold for small undertaking classification.  
  ***Key***: framework.size_thresholds.threshold_small_employees

- #### **Threshold — Medium: Assets**  
  ***Description***: Asset threshold for medium undertaking classification.  
  ***Key***: framework.size_thresholds.threshold_medium_assets

- #### **Threshold — Medium: Net Turnover**  
  ***Description***: Net turnover threshold for medium undertaking classification.  
  ***Key***: framework.size_thresholds.threshold_medium_net_turnover

- #### **Threshold — Medium: Employees**  
  ***Description***: Employee threshold for medium undertaking classification.  
  ***Key***: framework.size_thresholds.threshold_medium_employees

- #### **Threshold — Large: Assets**  
  ***Description***: Asset threshold for large undertaking classification.  
  ***Key***: framework.size_thresholds.threshold_large_assets

- #### **Threshold — Large: Net Turnover**  
  ***Description***: Net turnover threshold for large undertaking classification.  
  ***Key***: framework.size_thresholds.threshold_large_net_turnover

- #### **Threshold — Large: Employees**  
  ***Description***: Employee threshold for large undertaking classification.  
  ***Key***: framework.size_thresholds.threshold_large_employees

- #### **Is Micro Undertaking**  
  ***Description***: Flag indicating micro category based on thresholds (two out of three criteria).  
  ***Key***: framework.size_thresholds.is_micro_undertaking

- #### **Is Small Undertaking**  
  ***Description***: Flag indicating small category based on thresholds (two out of three criteria).  
  ***Key***: framework.size_thresholds.is_small_undertaking

- #### **Is Medium Undertaking**  
  ***Description***: Flag indicating medium category based on thresholds (two out of three criteria).  
  ***Key***: framework.size_thresholds.is_medium_undertaking

- #### **Is Large Undertaking**  
  ***Description***: Flag indicating large category based on thresholds (two out of three criteria).  
  ***Key***: framework.size_thresholds.is_large_undertaking

- #### **Is Public-Interest Entity**  
  ***Description***: Flag for PIE status per Member State law (e.g., listed issuers, banks, insurers).  
  ***Key***: framework.size_thresholds.is_public_interest_entity

# Financial Statements

## Balance Sheet  
***Description***: Assets, equity, and liabilities structured per Directive Annex formats.  
***Key***: financial_statements.balance_sheet

### Assets  
***Description***: Resources controlled by the entity expected to yield future economic benefits.  
***Key***: financial_statements.balance_sheet.assets

- #### **Intangible Assets**  
  ***Description***: Identifiable non-monetary assets without physical substance (e.g., development costs, software).  
  ***Key***: financial_statements.balance_sheet.assets.intangible_assets

- #### **Property, Plant and Equipment**  
  ***Description***: Tangible assets held for use in production, supply, rental, or administrative purposes.  
  ***Key***: financial_statements.balance_sheet.assets.property_plant_and_equipment

- #### **Investment Property**  
  ***Description***: Property held to earn rentals or for capital appreciation.  
  ***Key***: financial_statements.balance_sheet.assets.investment_property

- #### **Biological Assets**  
  ***Description***: Living plants or animals measured per national GAAP options.  
  ***Key***: financial_statements.balance_sheet.assets.biological_assets

- #### **Financial Assets — Non-current**  
  ***Description***: Long-term financial assets, including debt/equity instruments and loans.  
  ***Key***: financial_statements.balance_sheet.assets.financial_assets_noncurrent

- #### **Investments in Subsidiaries**  
  ***Description***: Interests in controlled entities (non-current).  
  ***Key***: financial_statements.balance_sheet.assets.investments_in_subsidiaries

- #### **Investments in Associates**  
  ***Description***: Interests with significant influence (non-current).  
  ***Key***: financial_statements.balance_sheet.assets.investments_in_associates

- #### **Investments in Joint Ventures**  
  ***Description***: Interests in joint arrangements classified as joint ventures.  
  ***Key***: financial_statements.balance_sheet.assets.investments_in_joint_ventures

- #### **Deferred Tax Assets**  
  ***Description***: Amounts of income taxes recoverable in future periods.  
  ***Key***: financial_statements.balance_sheet.assets.deferred_tax_assets

- #### **Inventories**  
  ***Description***: Assets held for sale, in production, or as materials to be consumed.  
  ***Key***: financial_statements.balance_sheet.assets.inventories

- #### **Trade Receivables**  
  ***Description***: Amounts due from customers for goods and services delivered.  
  ***Key***: financial_statements.balance_sheet.assets.trade_receivables

- #### **Other Receivables**  
  ***Description***: Receivables not classified as trade, including prepayments if separately shown.  
  ***Key***: financial_statements.balance_sheet.assets.other_receivables

- #### **Current Tax Assets**  
  ***Description***: Income taxes recoverable within 12 months.  
  ***Key***: financial_statements.balance_sheet.assets.current_tax_assets

- #### **Prepayments and Accrued Income**  
  ***Description***: Payments made or income accrued relating to future periods.  
  ***Key***: financial_statements.balance_sheet.assets.prepayments_and_accrued_income

- #### **Cash and Cash Equivalents**  
  ***Description***: Cash on hand, demand deposits, and highly liquid short-term investments.  
  ***Key***: financial_statements.balance_sheet.assets.cash_and_cash_equivalents

- #### **Total Assets**  
  ***Description***: Sum of non-current and current assets.  
  ***Key***: financial_statements.balance_sheet.assets.total_assets

### Equity and Liabilities  
***Description***: Equity attributable to owners and obligations to third parties.  
***Key***: financial_statements.balance_sheet.equity_and_liabilities

### Equity  
***Description***: Residual interest in the assets after deducting liabilities.  
***Key***: financial_statements.balance_sheet.equity_and_liabilities.equity

- ##### **Share Capital**  
  ***Description***: Paid-in capital issued by the entity.  
  ***Key***: financial_statements.balance_sheet.equity_and_liabilities.equity.share_capital

- #### **Share Premium**  
  ***Description***: Capital paid in above par value.  
  ***Key***: financial_statements.balance_sheet.equity_and_liabilities.equity.share_premium

- #### **Other Reserves**  
  ***Description***: Statutory, legal, or other reserves per national law.  
  ***Key***: financial_statements.balance_sheet.equity_and_liabilities.equity.other_reserves

- #### **Retained Earnings**  
  ***Description***: Accumulated profits or losses not distributed.  
  ***Key***: financial_statements.balance_sheet.equity_and_liabilities.equity.retained_earnings

- #### **Revaluation Reserve**  
  ***Description***: Reserve arising from asset revaluations where permitted.  
  ***Key***: financial_statements.balance_sheet.equity_and_liabilities.equity.revaluation_reserve

- #### **Profit or Loss — Current Year**  
  ***Description***: Result for the reporting period attributable to owners.  
  ***Key***: financial_statements.balance_sheet.equity_and_liabilities.equity.profit_or_loss_current_year

- #### **Non-controlling Interests**  
  ***Description***: Equity in subsidiaries not attributable to the parent.  
  ***Key***: financial_statements.balance_sheet.equity_and_liabilities.equity.non_controlling_interests

- #### **Total Equity**  
  ***Description***: Sum of all equity components.  
  ***Key***: financial_statements.balance_sheet.equity_and_liabilities.equity.total_equity

### Non-current Liabilities  
***Description***: Obligations due beyond 12 months.  
***Key***: financial_statements.balance_sheet.equity_and_liabilities.liabilities_noncurrent

- #### Provisions — Non-current 
  ***Description***: Long-term provisions (e.g., warranties, restructuring) expected beyond one year.  
  ***Key***: financial_statements.balance_sheet.equity_and_liabilities.liabilities_noncurrent.provisions_noncurrent

- #### **Employee Benefit Obligations**  
  ***Description***: Long-term employee benefit liabilities (e.g., pensions).  
  ***Key***: financial_statements.balance_sheet.equity_and_liabilities.liabilities_noncurrent.employee_benefit_obligations

- #### **Financial Liabilities — Non-current**  
  ***Description***: Long-term borrowings and other financial liabilities.  
  ***Key***: financial_statements.balance_sheet.equity_and_liabilities.liabilities_noncurrent.financial_liabilities_noncurrent

- #### **Deferred Tax Liabilities**  
  ***Description***: Income tax payable in future periods for temporary differences.  
  ***Key***: financial_statements.balance_sheet.equity_and_liabilities.liabilities_noncurrent.deferred_tax_liabilities

### Current Liabilities  
***Description***: Obligations due within 12 months.  
***Key***: financial_statements.balance_sheet.equity_and_liabilities.liabilities_current

- #### **Trade Payables**  
  ***Description***: Amounts payable to suppliers for goods and services received.  
  ***Key***: financial_statements.balance_sheet.equity_and_liabilities.liabilities_current.trade_payables

- #### **Other Payables**  
  ***Description***: Short-term non-trade obligations (e.g., payroll, VAT).  
  ***Key***: financial_statements.balance_sheet.equity_and_liabilities.liabilities_current.other_payables

- #### **Current Tax Liabilities**  
  ***Description***: Income tax payable within the next 12 months.  
  ***Key***: financial_statements.balance_sheet.equity_and_liabilities.liabilities_current.current_tax_liabilities

- #### **Accruals and Deferred Income**  
  ***Description***: Accrued expenses and deferred income recognized in current period.  
  ***Key***: financial_statements.balance_sheet.equity_and_liabilities.liabilities_current.accruals_and_deferred_income

- #### **Bank Borrowings — Current**  
  ***Description***: Short-term borrowings and current portions of long-term loans.  
  ***Key***: financial_statements.balance_sheet.equity_and_liabilities.liabilities_current.bank_borrowings_current

- #### **Total Liabilities**  
  ***Description***: Sum of non-current and current liabilities.  
  ***Key***: financial_statements.balance_sheet.equity_and_liabilities.total_liabilities

- #### **Total Equity and Liabilities**  
  ***Description***: Sum of total equity and total liabilities.  
  ***Key***: financial_statements.balance_sheet.equity_and_liabilities.total_equity_and_liabilities

## Profit and Loss  
***Description***: Income and expenses per Directive formats (by nature or function where permitted).  
***Key***: financial_statements.profit_and_loss

- #### **Revenue**  
  ***Description***: Income from ordinary activities (sales of goods and services).  
  ***Key***: financial_statements.profit_and_loss.revenue

- #### **Other Operating Income**  
  ***Description***: Income incidental to main operations (e.g., grants, rental income).  
  ***Key***: financial_statements.profit_and_loss.other_operating_income

- #### **Changes in Inventories**  
  ***Description***: Change in inventories of finished goods and work in progress.  
  ***Key***: financial_statements.profit_and_loss.changes_in_inventories

- #### **Raw Materials and Consumables**  
  ***Description***: Cost of materials and goods for resale.  
  ***Key***: financial_statements.profit_and_loss.raw_materials_and_consumables

- #### **Staff Costs**  
  ***Description***: Total employee-related costs.  
  ***Key***: financial_statements.profit_and_loss.staff_costs

- #### **Wages and Salaries**  
  ***Description***: Employee remuneration excluding social charges.  
  ***Key***: financial_statements.profit_and_loss.wages_and_salaries

- #### **Social Security Costs**  
  ***Description***: Employer social contributions and related charges.  
  ***Key***: financial_statements.profit_and_loss.social_security_costs

- #### **Depreciation and Amortisation**  
  ***Description***: Expense recognizing consumption of tangible and intangible assets.  
  ***Key***: financial_statements.profit_and_loss.depreciation_and_amortisation

- #### **Impairment**  
  ***Description***: Losses from asset impairment.  
  ***Key***: financial_statements.profit_and_loss.impairment

- #### **Other Operating Expenses**  
  ***Description***: Operating costs not classified elsewhere.  
  ***Key***: financial_statements.profit_and_loss.other_operating_expenses

- #### **Operating Result**  
  ***Description***: Result from operating activities before finance and tax.  
  ***Key***: financial_statements.profit_and_loss.operating_result

- #### **Interest Income**  
  ***Description***: Income from interest-bearing assets.  
  ***Key***: financial_statements.profit_and_loss.interest_income

- #### **Interest Expense**  
  ***Description***: Finance costs from borrowings and similar.  
  ***Key***: financial_statements.profit_and_loss.interest_expense

- #### **Other Financial Income**  
  ***Description***: Financial income not classified as interest.  
  ***Key***: financial_statements.profit_and_loss.other_financial_income

- #### **Other Financial Expense**  
  ***Description***: Financial expenses not classified as interest.  
  ***Key***: financial_statements.profit_and_loss.other_financial_expense

- #### **Financial Result**  
  ***Description***: Net result of financial income and expenses.  
  ***Key***: financial_statements.profit_and_loss.financial_result

- #### **Profit Before Tax**  
  ***Description***: Result before income tax expense.  
  ***Key***: financial_statements.profit_and_loss.profit_before_tax

- #### **Income Tax Expense**  
  ***Description***: Tax expense for the period.  
  ***Key***: financial_statements.profit_and_loss.income_tax_expense

- #### **Profit After Tax**  
  ***Description***: Result after income tax expense.  
  ***Key***: financial_statements.profit_and_loss.profit_after_tax

- #### **Extraordinary Items**  
  ***Description***: Items presented as extraordinary where allowed by Member State option.  
  ***Key***: financial_statements.profit_and_loss.extraordinary_items

- #### **Net Profit or Loss**  
  ***Description***: Final profit or loss for the period.  
  ***Key***: financial_statements.profit_and_loss.net_profit_or_loss

## Cash Flow Statement
***Description***: Operating, investing, and financing cash flows (if required or voluntary).  
***Key***: financial_statements.cash_flow_statement

- #### **Net Cash from Operating Activities**  
  ***Description***: Cash flows arising from principal revenue-producing activities.  
  ***Key***: financial_statements.cash_flow_statement.net_cash_from_operating_activities

- #### **Net Cash from Investing Activities**  
  ***Description***: Cash flows from acquisition/disposal of long-term assets and investments.  
  ***Key***: financial_statements.cash_flow_statement.net_cash_from_investing_activities

- #### **Net Cash from Financing Activities**  
  ***Description***: Cash flows from changes in equity and borrowings.  
  ***Key***: financial_statements.cash_flow_statement.net_cash_from_financing_activities

- #### **Effects of Exchange Rate Changes**  
  ***Description***: Effect of foreign exchange changes on cash and cash equivalents.  
  ***Key***: financial_statements.cash_flow_statement.effects_of_exchange_rate_changes

- #### **Net Increase (Decrease) in Cash**  
  ***Description***: Net change in cash and cash equivalents during the period.  
  ***Key***: financial_statements.cash_flow_statement.net_increase_decrease_in_cash

- #### **Cash and Cash Equivalents — Beginning**  
  ***Description***: Opening balance of cash and cash equivalents.  
  ***Key***: financial_statements.cash_flow_statement.cash_and_cash_equivalents_beginning

- #### **Cash and Cash Equivalents — Ending**  
  ***Description***: Closing balance of cash and cash equivalents.  
  ***Key***: financial_statements.cash_flow_statement.cash_and_cash_equivalents_ending

- ### Statement of Changes in Equity  
  ***Description***: Movements in equity components within the reporting period.  
  ***Key***: financial_statements.statement_of_changes_in_equity

- #### **Opening Equity**  
  ***Description***: Equity at the beginning of the period.  
  ***Key***: financial_statements.statement_of_changes_in_equity.opening_equity

- #### **Total Comprehensive Income**  
  ***Description***: Total of profit/loss and other recognized income/expense.  
  ***Key***: financial_statements.statement_of_changes_in_equity.total_comprehensive_income

- #### **Dividends**  
  ***Description***: Distributions to owners during the period.  
  ***Key***: financial_statements.statement_of_changes_in_equity.dividends

- #### **Other Changes in Equity**  
  ***Description***: Equity movements not captured elsewhere (e.g., reserves transfers).  
  ***Key***: financial_statements.statement_of_changes_in_equity.other_changes_in_equity

- #### **Closing Equity**  
  ***Description***: Equity at the end of the period.  
  ***Key***: financial_statements.statement_of_changes_in_equity.closing_equity

# Consolidation

## Scope and Relationships  
***Description***: Group structure indicators and scope assessments.  
***Key***: consolidation.scope_and_relationships

- #### **Is Parent**  
  ***Description***: Flag indicating the entity controls one or more subsidiaries.  
  ***Key***: consolidation.scope_and_relationships.is_parent

- #### **Has Subsidiaries**  
  ***Description***: Flag indicating the existence of subsidiaries.  
  ***Key***: consolidation.scope_and_relationships.has_subsidiaries

- #### **Exemption — Small Groups**  
  ***Description***: Exemption applicability for small groups from consolidation.  
  ***Key***: consolidation.scope_and_relationships.exemption_small_groups

- #### **Consolidated Financial Statements Required**  
  ***Description***: Requirement flag for preparing consolidated financial statements.  
  ***Key***: consolidation.scope_and_relationships.consolidated_financial_statements_required

## Methods  
***Description***: Consolidation methods used for group reporting.  
***Key***: consolidation.methods

- #### **Full Consolidation**  
  ***Description***: Method applied to subsidiaries under control.  
  ***Key***: consolidation.methods.full_consolidation

- #### **Equity Method**  
  ***Description***: Method applied to associates and certain joint ventures.  
  ***Key***: consolidation.methods.equity_method

## Disclosures  
***Description***: Group-related disclosures in notes.  
***Key***: consolidation.disclosures

- #### **Related Party Disclosures Required**  
  ***Description***: Requirement flag for related party disclosures at group level.  
  ***Key***: consolidation.disclosures.related_party_disclosures_required

# Audit and Publication

***Description***: Statutory audit and filing obligations.  
***Key***: audit_and_publication

- #### **Audit Required**  
  ***Description***: Flag indicating whether the financial statements require a statutory audit.  
  ***Key***: audit_and_publication.audit_required

- #### **Audit Report Type**  
  ***Description***: Type of auditor’s opinion or report.  
  ***Key***: audit_and_publication.audit_report_type

- #### **Filing Required**  
  ***Description***: Requirement to file financial statements with the public registry.  
  ***Key***: audit_and_publication.filing_required

- #### **Filing Deadline (Days)**  
  ***Description***: Filing deadline measured in days from period end, per national law.  
  ***Key***: audit_and_publication.filing_deadline_days

# Management Report

***Description***: Requirements for the management report and related statements.  
***Key***: management_report

- #### **Management Report Required**  
  ***Description***: Flag indicating whether a management report is required.  
  ***Key***: management_report.management_report_required

- #### **Non-financial Information Required**  
  ***Description***: Requirement for non-financial information (note: NFRD/CSRD may apply).  
  ***Key***: management_report.non_financial_information_required

- #### **Corporate Governance Statement Required**  
  ***Description***: Requirement for a corporate governance statement (typically for PIEs with listed shares).  
  ***Key***: management_report.corporate_governance_statement_required

# Notes

***Description***: Notes and narrative disclosures accompanying the financial statements.  
***Key***: notes

- #### **Accounting Policies**  
  ***Description***: Significant accounting policies and measurement bases.  
  ***Key***: notes.accounting_policies

- #### **Post Balance Sheet Events**  
  ***Description***: Events after the reporting period requiring disclosure.  
  ***Key***: notes.post_balance_sheet_events

- #### **Contingent Liabilities**  
  ***Description***: Possible obligations not recognized as liabilities.  
  ***Key***: notes.contingent_liabilities

- #### **Commitments**  
  ***Description***: Notable commitments such as capital commitments and leases.  
  ***Key***: notes.commitments

- #### **Related Party Transactions**  
  ***Description***: Transactions with related parties and outstanding balances.  
  ***Key***: notes.related_party_transactions

- #### **Average Employees**  
  ***Description***: Average number of employees during the financial year.  
  ***Key***: notes.average_employees

- #### **Directors’ Remuneration**  
  ***Description***: Remuneration disclosures for administrative, management, and supervisory bodies.  
  ***Key***: notes.directors_remuneration

- #### **Auditor Fees Breakdown**  
  ***Description***: Fees payable to the auditor, broken down by category where required.  
  ***Key***: notes.auditor_fees_breakdown

- #### **Own Shares Information**  
  ***Description***: Information on acquisition/holding/disposal of own shares.  
  ***Key***: notes.own_shares_information

- #### **Revalued Assets — Basis**  
  ***Description***: Basis and methods for revaluation where applicable.  
  ***Key***: notes.revalued_assets_basis

- #### **Off-balance Sheet Arrangements**  
  ***Description***: Nature and business purpose of off-BS arrangements and risks.  
  ***Key***: notes.off_balance_sheet_arrangements

- #### **Financial Instruments — Risk**  
  ***Description***: Information on financial risk management and exposures.  
  ***Key***: notes.financial_instruments_risk

- #### **Deferred Taxes — Detail**  
  ***Description***: Breakdown and movements in deferred tax assets and liabilities.  
  ***Key***: notes.deferred_taxes_detail

- #### **Provisions — Movement**  
  ***Description***: Reconciliations of provisions by class.  
  ***Key***: notes.provisions_movement

- #### **Government Grants**  
  ***Description***: Nature and extent of government grants recognized.  
  ***Key***: notes.government_grants

# Member State Options

## Reliefs  
***Description***: Optional reliefs and exemptions offered by Member States.  
***Key***: member_state_options.reliefs

- #### **Micro — Notes Abridged**  
  ***Description***: Abridged notes permitted for micro-undertakings.  
  ***Key***: member_state_options.reliefs.micro_notes_abridged

- #### **Small — Balance Sheet Abridged**  
  ***Description***: Abridged balance sheet permitted for small undertakings.  
  ***Key***: member_state_options.reliefs.small_balance_sheet_abridged

- #### **Small — Profit and Loss Abridged**  
  ***Description***: Abridged profit and loss permitted for small undertakings.  
  ***Key***: member_state_options.reliefs.small_profit_and_loss_abridged

- #### **Small — Notes Reduced**  
  ***Description***: Reduced notes permitted for small undertakings.  
  ***Key***: member_state_options.reliefs.small_notes_reduced

- #### **Small — Directors’ Report Exemption**  
  ***Description***: Exemption from directors’ report for small undertakings where allowed.  
  ***Key***: member_state_options.reliefs.small_directors_report_exemption

- #### **Small — Audit Exemption**  
  ***Description***: Exemption from statutory audit for small undertakings where allowed.  
  ***Key***: member_state_options.reliefs.small_audit_exemption

## Options  
***Description***: Measurement and presentation options available under national transpositions.  
***Key***: member_state_options.options

- #### **Revaluation Model Permitted**  
  ***Description***: Permission to revalue certain assets with revaluation reserve.  
  ***Key***: member_state_options.options.revaluation_model_permitted

- #### **Capitalisation of Development Costs**  
  ***Description***: Option to capitalize development costs under specified criteria.  
  ***Key***: member_state_options.options.capitalisation_of_development_costs

- #### **Extraordinary Items Format Permitted**  
  ***Description***: Permission to present extraordinary items in profit and loss.  
  ***Key***: member_state_options.options.extraordinary_items_format_permitted

- #### **Fair Value Financial Instruments Permitted**  
  ***Description***: Option to measure specified financial instruments at fair value.  
  ***Key***: member_state_options.options.fair_value_financial_instruments_permitted

# Metadata

***Description***: Reporting metadata used for processing and presentation.  
***Key***: metadata

- #### **Financial Statements Currency**  
  ***Description***: Reporting currency of the financial statements.  
  ***Key***: metadata.financial_statements_currency

- #### **Reporting Period Start**  
  ***Description***: Start date of the reporting period.  
  ***Key***: metadata.reporting_period_start

- #### **Reporting Period End**  
  ***Description***: End date of the reporting period.  
  ***Key***: metadata.reporting_period_end

- #### **Consolidated Flag**  
  ***Description***: Indicates whether the statements are consolidated.  
  ***Key***: metadata.consolidated_flag

- #### **GAAP Framework**  
  ***Description***: Accounting framework applied (e.g., national GAAP, IFRS as adopted by the EU).  
  ***Key***: metadata.gaap_framework

- #### **Layout — Balance Sheet**  
  ***Description***: Balance sheet layout applied per national options.  
  ***Key***: metadata.layout_balance_sheet

- #### **Layout — Profit and Loss**  
  ***Description***: Profit and loss layout applied per national options.  
  ***Key***: metadata.layout_profit_and_loss

- #### **Materiality Policy**  
  ***Description***: Materiality thresholds/policies applied in financial reporting.  
  ***Key***: metadata.materiality_policy

- #### **Rounding Policy**  
  ***Description***: Rounding policy used in amounts presented.  
  ***Key***: metadata.rounding_policy
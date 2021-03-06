﻿namespace BetterCorp.Tools.WHMCS.Models
{
  using System;
  using System.Collections.Generic;
  using System.Net;
  
  public class AddClientResponse : IResponse
  {
    public long clientid { get; set; }
  }

  public class GetClientsResponse : IResponse
  {
    public string totalresults { get; set; }

    public long startnumber { get; set; }

    public long numreturned { get; set; }

    public GetClientsResponseClients clients { get; set; }
  }

  public class GetClientsResponseClients : IResponse
  {
    public List<Client> client { get; set; }
  }

  public class GetClientsDetailsResponse : Client
  {
  }

  public class GetClientsDetailsWithStatsResponse : IResponse
  {
    public Client client { get; set; }

    public ClientStats stats { get; set; }
  }

  public class Client : IResponse
  {
    public long userid { get; set; }

    public long id { get; set; }

    public string uuid { get; set; }

    public string firstname { get; set; }

    public string lastname { get; set; }

    public string fullname { get; set; }

    public string companyname { get; set; }

    public string email { get; set; }

    public string address1 { get; set; }

    public string address2 { get; set; }

    public string city { get; set; }

    public string fullstate { get; set; }

    public string state { get; set; }

    public string postcode { get; set; }

    public string countrycode { get; set; }

    public string country { get; set; }

    public string phonenumber { get; set; }

    public string password { get; set; }

    public string statecode { get; set; }

    public string countryname { get; set; }

    public int phonecc { get; set; }

    public string phonenumberformatted { get; set; }

    public string billingcid { get; set; }

    public string notes { get; set; }

    public bool twofaenabled { get; set; }

    public string currency { get; set; }

    public string defaultgateway { get; set; }

    public string cctype { get; set; }

    public string cclastfour { get; set; }

    public string securityqid { get; set; }

    public string securityqans { get; set; }

    public string groupid { get; set; }

    public string status { get; set; }

    public string credit { get; set; }

    public bool taxexempt { get; set; }

    public bool latefeeoveride { get; set; }

    public bool overideduenotices { get; set; }

    public bool separateinvoices { get; set; }

    public bool disableautocc { get; set; }

    public bool emailoptout { get; set; }

    public bool overrideautoclose { get; set; }

    public string allowSingleSignOn { get; set; }

    public string language { get; set; }

    public string lastlogin { get; set; }

    public string customfields1 { get; set; }

    public List<ClientCustomfield> customfields { get; set; }

    public string currency_code { get; set; }
  }

  public class ClientCustomfield
  {
    public string id { get; set; }

    public string value { get; set; }
  }

  public class ClientStats
  {
    public string numdueinvoices { get; set; }

    public string dueinvoicesbalance { get; set; }

    public string income { get; set; }

    public bool incredit { get; set; }

    public string creditbalance { get; set; }

    public string numoverdueinvoices { get; set; }

    public string overdueinvoicesbalance { get; set; }

    public string numDraftInvoices { get; set; }

    public string draftInvoicesBalance { get; set; }

    public long numpaidinvoices { get; set; }

    public string paidinvoicesamount { get; set; }

    public long numunpaidinvoices { get; set; }

    public string unpaidinvoicesamount { get; set; }

    public string numcancelledinvoices { get; set; }

    public string cancelledinvoicesamount { get; set; }

    public long numrefundedinvoices { get; set; }

    public string refundedinvoicesamount { get; set; }

    public long numcollectionsinvoices { get; set; }

    public string collectionsinvoicesamount { get; set; }

    public long productsnumactivehosting { get; set; }

    public long productsnumhosting { get; set; }

    public long productsnumactivereseller { get; set; }

    public long productsnumreseller { get; set; }

    public long productsnumactiveservers { get; set; }

    public long productsnumservers { get; set; }

    public long productsnumactiveother { get; set; }

    public long productsnumother { get; set; }

    public long productsnumactive { get; set; }

    public long productsnumtotal { get; set; }

    public long numactivedomains { get; set; }

    public long numdomains { get; set; }

    public long numacceptedquotes { get; set; }

    public long numquotes { get; set; }

    public long numtickets { get; set; }

    public long numactivetickets { get; set; }

    public string numaffiliatesignups { get; set; }

    public bool isAffiliate { get; set; }
  }

  public class BaseContactResponse : IResponse
  { 
    public long contactid { get; set; }
  }

  public class BaseClientResponse : IResponse
  { 
    public long clientid { get; set; }
  }

  public class GetCancelledPackages : IResponse
  {
    public long totalresults { get; set; }

    public long startnumber { get; set; }

    public long numreturned { get; set; }

    public List<GetCancelledPackage> packages { get; set; }
  }

  public class GetCancelledPackage : IResponse
  {
    public long id { get; set; }

    public DateTime date { get; set; }

    public long relid { get; set; }

    public string reason { get; set; }

    public string type { get; set; }

    public DateTime created_at { get; set; }

    public DateTime updated_at { get; set; }
  }

  public class GetClientGroupsResponse : IResponse
  {
    public long totalresults { get; set; }
    public List<GetClientGroup> groups { get; set; }
  }

  public class GetClientGroup
  {
    public long id { get; set; }

    public string groupname { get; set; }

    public string groupcolour { get; set; }

    public string discountpercent { get; set; }

    public float? DiscountPercent
      => string.IsNullOrEmpty(discountpercent) ? null : (float?) float.Parse(discountpercent.Replace('.', ','));

    public string susptermexempt { get; set; }

    public string separateinvoices { get; set; }
  }

  public class GetClientPasswordResponse : IResponse
  {
    public string password { get; set; }
  }

  public class GetClientsAddonsResponse : IResponse
  {
    public long totalresults { get; set; }

    public long serviceid { get; set; }

    public long clientid { get; set; }

    public List<GetClientsAddon> addons { get; set; }
  }

  public class GetClientsAddon
  {
    public long id { get; set; }

    public long userid { get; set; }

    public long orderid { get; set; }

    public long serviceid { get; set; }

    public long addonid { get; set; }

    public string name { get; set; }

    public string setupfee { get; set; }

    public string recurring { get; set; }

    public string billingcycle { get; set; }

    public string tax { get; set; }

    public string status { get; set; }

    public DateTime regdate { get; set; }

    public DateTime nextduedate { get; set; }

    public DateTime nextinvoicedate { get; set; }

    public string paymentmethod { get; set; }

    public string notes { get; set; }
  }

  public class GetClientsDomainsResponse : IResponse
  {
    public long clientid { get; set; }

    public long domainid { get; set; }

    public long totalresults { get; set; }

    public long startnumber { get; set; }

    public long numreturned { get; set; }

    public List<GetClientsDomain> domains { get; set; }
  }

  public class GetClientsDomain
  {
    public long id { get; set; }

    public long userid { get; set; }

    public long orderid { get; set; }

    public string regtype { get; set; }

    public string domainname { get; set; }

    public string registrar { get; set; }

    public string regperiod { get; set; }

    public string firstpaymentamount { get; set; }

    public string recurringamount { get; set; }

    public string paymentmethod { get; set; }

    public string paymentmethodname { get; set; }

    public DateTime regdate { get; set; }

    public DateTime expirydate { get; set; }

    public DateTime nextduedate { get; set; }

    public string status { get; set; }

    public long subscriptionid { get; set; }

    public long promoid { get; set; }

    public bool dnsmanagement { get; set; }

    public bool emailforwarding { get; set; }

    public long idprotection { get; set; }

    public bool donotrenew { get; set; }

    public string notes { get; set; }
  }

  public class GetClientsProductsResponse : IResponse
  {
    public long clientid { get; set; }

    public long serviceid { get; set; }

    public long pid { get; set; }

    public string domain { get; set; }

    public long totalresults { get; set; }

    public long startnumber { get; set; }

    public long numreturned { get; set; }

    public List<GetClientsProduct> products { get; set; }
  }

  public class GetClientsProduct
  {
    public long id { get; set; }
    public long clientid { get; set; }
    public long orderid { get; set; }
    public long pid { get; set; }
    public DateTime regdate { get; set; }
    public string name { get; set; }
    public string translated_name { get; set; }
    public string groupname { get; set; }
    public string translated_groupname { get; set; }
    public string domain { get; set; }
    public string dedicatedip { get; set; }
    public long serverid { get; set; }
    public string servername { get; set; }
    public string serverip { get; set; }
    public string serverhostname { get; set; }
    public string suspensionreason { get; set; }
    public string firstpaymentamount { get; set; }
    public string recurringamount { get; set; }
    public string paymentmethod { get; set; }
    public string paymentmethodname { get; set; }
    public string billingcycle { get; set; }
    public DateTime nextduedate { get; set; }
    public string status { get; set; }
    public string username { get; set; }
    public string password { get; set; }
    public string subscriptionid { get; set; }
    public long promoid { get; set; }
    public string overideautosuspend { get; set; }
    public DateTime overidesuspenduntil { get; set; }
    public string ns1 { get; set; }
    public string ns2 { get; set; }
    public string assignedips { get; set; }
    public string notes { get; set; }
    public string diskusage { get; set; }
    public string disklimit { get; set; }
    public string bwusage { get; set; }
    public string bwlimit { get; set; }
    public DateTime lastupdate { get; set; }
    public List<ClientCustomfield> customfields { get; set; }
    public List<ProductConfigurationOption> configoptions { get; set; }
  }

  public class ProductConfigurationOption
  {
    public string id { get; set; }
    public string option { get; set; }
    public string type { get; set; }
    public string value { get; set; }
  }
}
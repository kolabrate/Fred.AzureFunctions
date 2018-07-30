// The 'From' and 'To' fields are automatically populated with the values specified by the binding settings.
//
// You can also optionally configure the default From/To addresses globally via host.config, e.g.:
//
// {
//   "sendGrid": {
//      "to": "user@host.com",
//      "from": "Azure Functions <samples@functions.com>"
//   }
// }
#r "SendGrid"


using System;
using SendGrid.Helpers.Mail;
using Microsoft.Azure.WebJobs.Host;

public static Mail Run(Order order, TraceWriter log)
{
    log.Info($"C# Queue trigger function processed order: {order.OrderId}");

    Mail message = new Mail()
    {
        Subject = $"Thanks for your order (#{order.OrderId})!"
    };

    Content content = new Content
    {
        Type = "text/plain",
        Value = $"{order.CustomerName}, your order ({order.OrderId}) is being processed!"
    };

    message.AddContent(content);
    return message;
}
    public class SiteDetail
    {
        public string SiteId { get; set; }
        public string ApprovalNo { get; set; }
        public string PBSId { get; set; }
        public string BusinessName { get; set; }
        public string OwnerName { get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string PostCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string ABN { get; set; }
        public string HPIO { get; set; }
        public string EntityId { get; set; }
        public string ProgramId { get; set; }

    }

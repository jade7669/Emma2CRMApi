using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Emma2CRMApi.Models
{
    public class DbInitialSeed : DropCreateDatabaseIfModelChanges<E2CDbContext>
    {
        protected override void Seed(E2CDbContext context)
        {
            context.Subscriptions.Add(
                new E2CClientBaseInfo
                {
                    CRMUserName = "jessica@crminnovation.com",
                    CRMPassword = "Innovate1!",
                    CrmUrl = "https://crminnovation.crm.dynamics.com",
                    EmmaAccountID = "1776822",
                    EmmaPublicKey = "775d446173fc7b54fbd6",
                    EmmaPrivateKey = "bae19fc8613547444a74",
                    EmmaUserName = "sao_wei@yahoo.com",
                    EmmaPassword = "EmmaRul3$",
                    LicenseExpireDate = new DateTime(2028, 12, 31),
                    SolutionStartDate = new DateTime(2028, 6, 6),
                    IsActive = true
                });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Emma2CRMApi.Models
{
    public class E2CClientBaseInfo
    {
        #region BASIC
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public DateTime LicenseExpireDate { get; set; }

        public DateTime SolutionStartDate { get; set; }

        public bool IsActive { get; set; }
        #endregion

        #region CRM
        [Required(ErrorMessage = "Please provide CRM User Name")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Length must be within 2 to 100 characters")]
        public string CRMUserName { get; set; }

        [Required(ErrorMessage = "Please provide CRM Password")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Length must be at least 2 characters")]
        public string CRMPassword { get; set; }

        [Required]
        public string CrmUrl { get; set; }
        #endregion

        #region EMMA
        [Required(ErrorMessage = "Please provide Emma User Name")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Length must be within 2 to 100 characters")]
        public string EmmaUserName { get; set; }

        [Required(ErrorMessage = "Please provide Emma Password")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Length must be at least 2 characters")]
        public string EmmaPassword { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "Please provide Emma Public Key")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Length must be within 2 to 100 characters")]
        public string EmmaPublicKey { get; set; }

        [Required(ErrorMessage = "Please provide Emma Private Key")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Length must be within 2 to 100 characters")]
        public string EmmaPrivateKey { get; set; }

        [Required(ErrorMessage = "Please provide Emma Account ID")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Length must be within 2 to 100 characters")]
        public string EmmaAccountID { get; set; }
        #endregion
    }
}
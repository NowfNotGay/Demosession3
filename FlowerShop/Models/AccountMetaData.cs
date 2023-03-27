using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FlowerShop.Models;

public class AccountMetaData
{
    [Required]
    [MinLength(6)]
    [MaxLength(24)]
    public string Username { get; set; }

    [Required]
    [RegularExpression("((?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{6,20})")]
    public string Password { get; set; }
    
    [Required]
    public string FullName { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

}
[ModelMetadataType(typeof(AccountMetaData))]
public partial class Account
{

}

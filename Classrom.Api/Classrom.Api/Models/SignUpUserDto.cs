﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Classrom.Api.Models;
public class SignUpUserDto
{
	[Required]
	public string? UserName { get; set; }
	[Required]
	public string? FirstName { get; set; }
	public string? LastName { get; set; }
	[Required]
	public string? Password { get; set; }
	public string? ConfirmPassword { get; set; }
}

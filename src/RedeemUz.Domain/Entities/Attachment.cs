﻿using Taxify.Domain.Commons;
namespace Taxify.Domain.Entities;

public class Attachment : Auditable
{
    public string FileName { get; set; }
    public string FilePath { get; set; }
}

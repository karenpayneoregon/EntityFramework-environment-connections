﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using EntityFrameworkCoreLibrary1.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;

namespace EntityFrameworkCoreLibrary1.Contexts
{
    public class ContactTypeConfiguration : IEntityTypeConfiguration<ContactType>
    {
        public void Configure(EntityTypeBuilder<ContactType> entity)
        {
            entity.HasKey(e => e.ContactTypeIdentifier);
        }
    }
}
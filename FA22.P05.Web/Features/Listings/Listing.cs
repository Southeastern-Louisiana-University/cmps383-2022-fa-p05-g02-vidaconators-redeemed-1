﻿using FA22.P05.Web.Features.Authorization;
using FA22.P05.Web.Features.ItemListings;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace FA22.P05.Web.Features.Listings;

public class Listing
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public string? Publisher { get; set; }
    public string? Version { get; set; }
    public string? Country { get; set; }
    public string? Language { get; set; }
    public int Year { get; set; }
    public char Condition { get; set; }
    public DateTimeOffset StartUtc { get; set; }
    public DateTimeOffset EndUtc { get; set; }
    public int OwnerId { get; set; }
    public virtual User? Owner { get; set; }
    public virtual ICollection<ItemListing> ItemsForSale { get; set; } = new List<ItemListing>();
}

﻿using System;
namespace CityInfo.API.Models
{
	public class PointOfInterestDto
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string? Desctription { get; set; }

	}
}


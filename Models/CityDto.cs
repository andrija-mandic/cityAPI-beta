﻿using System;
namespace CityInfo.API.Models
{
	public class CityDto
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string? Desctription { get; set; }

		public int NumberOfPointsOfInterest
		{
			get
			{
				return PointsOfInterest.Count;
			}
		}

		public ICollection<PointOfInterestDto> PointsOfInterest { get; set; } = new List<PointOfInterestDto>();
	}
}

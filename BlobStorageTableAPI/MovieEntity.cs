using Microsoft.Azure.Cosmos.Table;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlobStorageTableAPI
{
	public class MovieEntity : TableEntity
	{
		public MovieEntity(string genre, string movieTitle)
		{
			base.PartitionKey = genre;
			base.RowKey = movieTitle;
		}

		public MovieEntity() { }

		public string Genre => base.PartitionKey;

		public string Title => base.RowKey;

		public int Year { get; set; }

		public string Length { get; set; }

		public string Description { get; set; }

		public static explicit operator MovieEntity(TableResult v)
		{
			throw new NotImplementedException();
		}
	}
}

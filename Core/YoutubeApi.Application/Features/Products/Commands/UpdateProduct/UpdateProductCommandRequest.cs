﻿using MediatR;

namespace YoutubeApi.Application.Features.Products.Commands.UpdateProduct
{
    public class UpdateProductCommandRequest : IRequest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int BrandId { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }

        public IList<int> CategoryIds { get; set; }
    }
}
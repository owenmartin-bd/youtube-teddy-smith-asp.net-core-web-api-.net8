using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_Core_Web_API_.NET_8.Dtos.Comment;
using ASP.NET_Core_Web_API_.NET_8.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ASP.NET_Core_Web_API_.NET_8.Mappers
{
    public static class CommentMapper
    {
        public static CommentDto ToCommentDto(this Comment commentModel)
        {
            return new CommentDto
            {
                Id = commentModel.Id,
                Title = commentModel.Title,
                Content = commentModel.Content,
                CreatedOn = commentModel.CreatedOn,
                StockId = commentModel.StockId,
            };
        }

        public static Comment ToCommentFromCreate(
            this CreateCommentDto commentDto,
            int stockId)
        {
            return new Comment
            {
                Title = commentDto.Title,
                Content = commentDto.Content,
                StockId = stockId,
            };
        }

        public static Comment ToCommentFromUpdate(
            this UpdateCommentRequestDto commentDto)
        {
            return new Comment
            {
                Title = commentDto.Title,
                Content = commentDto.Content
            };
        }
    }
}
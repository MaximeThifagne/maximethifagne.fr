
 
 

 

/// <reference path="Enums.ts" />

declare namespace MaximeThifagne.DTO {
	interface ArticleDto {
		ArticleBody: string;
		ArticleCreationDate: Date;
		ArticleId: number;
		ArticlePhoto: number[];
		ArticleSource: string;
		ArticleSourceLink: string;
		ArticleTitle: string;
		Category: MaximeThifagne.DTO.Enum.CategoryEnum;
		Comments: MaximeThifagne.DTO.CommentDto[];
		SubArticles: MaximeThifagne.DTO.SubArticleDto[];
		User: MaximeThifagne.DTO.UserDto;
	}
	interface CommentDto {
		Article: MaximeThifagne.DTO.ArticleDto;
		CommentatorEmail: string;
		CommentatorName: string;
		CommentatorWebSite: string;
		CommentDate: Date;
		CommentId: number;
		CommentMessage: string;
	}
	interface ContactDto {
		UserEmail: string;
		UserMessage: string;
		UserName: string;
		UserPhoneNumber: string;
		UserWebSite: string;
	}
	interface SubArticleDto {
		Article: MaximeThifagne.DTO.ArticleDto;
		SubArticleBody: string;
		SubArticleId: number;
		SubArticlePhoto: number[];
		SubArticleTitle: string;
	}
	interface UserDto {
		UserFirstName: string;
		UserId: number;
		UserLastName: string;
		UserLogin: string;
		UserPassword: string;
	}
}



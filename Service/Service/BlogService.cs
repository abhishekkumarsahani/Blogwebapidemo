using Dapper;
using Helper.Dapper;
using Models;
using Newtonsoft.Json;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Service.Service
{
    public class BlogService : IBlogInterface
    {

        public async Task<dynamic> BlogCategory(BlogCategory req)
        {
            try
            {
                var procedure = "sp_blog_category";
                var parameter = new DynamicParameters();
                parameter.Add("@userid", req.UserID);
                parameter.Add("@categoryid", req.CategoryID);
                parameter.Add("@categoryname", req.CategoryName);
                parameter.Add("@slug", req.Slug);
                parameter.Add("@categoryicon", req.CategoryIcon);
                parameter.Add("@isprimary", req.IsPrimary);
                parameter.Add("@flag", req.Flag);

                var data = DbHelper.RunProc<dynamic>(procedure, parameter);

                if (data.Count() != 0 && data.FirstOrDefault()?.Message == null)
                {
                    return new
                    {
                        StatusCode = 200,
                        Message = "Success",
                        Data = data.ToList()
                    };
                }
                else if (data.Count() == 1 && data.FirstOrDefault()?.Message != null)
                {
                    return new
                    {
                        StatusCode = data.FirstOrDefault().StatusCode,
                        Message = data.FirstOrDefault().Message
                    };
                }
                else
                {
                    return new
                    {
                        StatusCode = 400,
                        Message = "No Data"
                    };
                }
            }
            catch (Exception ex)
            {
                return new
                {
                    StatusCode = 500,
                    Message = ex.Message
                };
            }
        }

        public async Task<dynamic> BlogTags(BlogTags req)
        {
            try
            {
                var procedure = "sp_blog_tags";
                var parameter = new DynamicParameters();
                parameter.Add("@userid", req.UserID);
                parameter.Add("@tagsid", req.TagsID);
                parameter.Add("@tagname", req.TagName);
                parameter.Add("@slug", req.Slug);
                parameter.Add("@istrending", req.IsTrending);
                parameter.Add("@flag", req.Flag);

                var data = DbHelper.RunProc<dynamic>(procedure, parameter);

                if (data.Count() != 0 && data.FirstOrDefault()?.Message == null)
                {
                    return new
                    {
                        StatusCode = 200,
                        Message = "Success",
                        Data = data.ToList()
                    };
                }
                else if (data.Count() == 1 && data.FirstOrDefault()?.Message != null)
                {
                    return new
                    {
                        StatusCode = data.FirstOrDefault().StatusCode,
                        Message = data.FirstOrDefault().Message
                    };
                }
                else
                {
                    return new
                    {
                        StatusCode = 400,
                        Message = "No Data"
                    };
                }

            }
            catch (Exception ex)
            {
                return new
                {
                    StatusCode = 500,
                    Message = ex.Message,
                };
            }
        }
        public async Task<dynamic> BlogPost(BlogPost req)
        {
            try
            {
                var procedure = "sp_blog_post";
                var parameter = new DynamicParameters();
                parameter.Add("@userid", req.UserID);
                parameter.Add("@blogsid", req.BlogsID);
                parameter.Add("@categoryid", req.CategoryID);
                parameter.Add("@title", req.Title);
                parameter.Add("@slug", req.Slug);
                parameter.Add("@post", req.Post);
                parameter.Add("@featimg", req.FeatImg); // Base64 image
                parameter.Add("@excerpt", req.Excerpt);
                parameter.Add("@meta", req.Meta);
                parameter.Add("@isvideofeat", req.IsVideoFeat);
                parameter.Add("@postview", req.PostView);
                parameter.Add("@ispublished", req.IsPublished);
                parameter.Add("@flag", req.Flag);

                var data = DbHelper.RunProc<dynamic>(procedure, parameter);

                if (data.Count() != 0 && data.FirstOrDefault()?.Message == null)
                {
                    return new
                    {
                        StatusCode = 200,
                        Message = "Success",
                        Data = data.ToList()
                    };
                }
                else if (data.Count() == 1 && data.FirstOrDefault()?.Message != null)
                {
                    return new
                    {
                        StatusCode = data.FirstOrDefault().StatusCode,
                        Message = data.FirstOrDefault().Message
                    };
                }
                else
                {
                    return new
                    {
                        StatusCode = 400,
                        Message = "No Data"
                    };
                }
            }
            catch (Exception ex)
            {
                return new
                {
                    StatusCode = 500,
                    Message = ex.Message
                };
            }
        }
        public async Task<dynamic> BlogPostTags(PostTag req)
        {
            try
            {
                var procedure = "sp_post_tags";
                var parameter = new DynamicParameters();
                parameter.Add("@tagsid", req.PostTagsId);
                parameter.Add("@postid", req.PostId);
                parameter.Add("@userid", req.UserID);
                parameter.Add("@tagsid", req.TagsId);
                parameter.Add("@flag", req.Flag);
                var data = DbHelper.RunProc<dynamic>(procedure, parameter);

                if (data.Count() != 0 && data.FirstOrDefault()?.Message == null)
                {
                    return new
                    {
                        StatusCode = 200,
                        Message = "Success",
                        Data = data.ToList()
                    };
                }
                else if (data.Count() == 1 && data.FirstOrDefault()?.Message != null)
                {
                    return new
                    {
                        StatusCode = data.FirstOrDefault().StatusCode,
                        Message = data.FirstOrDefault().Message
                    };
                }
                else
                {
                    return new
                    {
                        StatusCode = 400,
                        Message = "No Data"
                    };
                }
            }
            catch (Exception ex)
            {
                return new
                {
                    StatusCode = 500,
                    Message = ex.Message
                };
            }
        }
        public async Task<dynamic> Bus(Bus request)
        {
            try
            {
                var procedure = "sp_manage_bus";
                var parameters = new DynamicParameters();
                parameters.Add("@UserID", request.UserID);
                parameters.Add("@SchID", request.SchID);
                parameters.Add("@Flag", request.Flag);
                parameters.Add("@IsActive", request.IsActive);
                parameters.Add("@BusNumber", request.BusNumber);
                parameters.Add("@DriverName", request.DriverName);
                parameters.Add("@DriverContact", request.DriverContact);
                parameters.Add("@BusID", request.BusID);

                var data = DbHelper.RunProc<dynamic>(procedure, parameters);

                if (data.Count() != 0 && data.FirstOrDefault()?.Message == null)
                {
                    return new
                    {
                        StatusCode = 200,
                        Message = "Success",
                        Data = data.ToList()
                    };
                }
                else if (data.Count() == 1 && data.FirstOrDefault()?.Message != null)
                {
                    return new
                    {
                        StatusCode = data.FirstOrDefault().StatusCode,
                        Message = data.FirstOrDefault().Message
                    };
                }
                else
                {
                    return new
                    {
                        StatusCode = 400,
                        Message = "No Data"
                    };
                }
            }
            catch (Exception ex)
            {
                return new
                {
                    StatusCode = 500,
                    Message = ex.Message
                };
            }
        }

        public async Task<dynamic> AssignBus(AssignBus request)
        {
            try
            {
                var procedure = "sp_assign_bus";
                var parameters = new DynamicParameters();
                parameters.Add("@UserID", request.UserID);
                parameters.Add("@ImeiID", request.ImeiID);
                parameters.Add("@SchID", request.SchID);
                parameters.Add("@Flag", request.Flag);
                parameters.Add("@BusID", request.BusID);
                parameters.Add("@PickupLocation", request.PickupLocation);
                parameters.Add("@DropoffLocation", request.DropoffLocation);

                // Convert Students list to XML string
                var studentsXml = new XElement("Students",
                    request.Students.Select(s => new XElement("Student",
                        new XElement("StudentID", s.StudentID)))).ToString();

                parameters.Add("@Students", studentsXml, DbType.Xml);

                var data = DbHelper.RunProc<dynamic>(procedure, parameters); // Ensure this is an async call

                if (data != null && data.Any())
                {
                    var firstRecord = data.FirstOrDefault();
                    if (firstRecord?.Message != null)
                    {
                        return new
                        {
                            StatusCode = firstRecord.StatusCode,
                            Message = firstRecord.Message
                        };
                    }
                    else
                    {
                        return new
                        {
                            StatusCode = 200,
                            Message = "Success",
                            Data = data.ToList()
                        };
                    }
                }
                else
                {
                    return new
                    {
                        StatusCode = 400,
                        Message = "No Data"
                    };
                }
            }
            catch (Exception ex)
            {
                return new
                {
                    StatusCode = 500,
                    Message = ex.Message
                };
            }
        }




    }
}

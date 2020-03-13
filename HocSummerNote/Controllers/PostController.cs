using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HocSummerNote.Models;
using System.IO;

namespace HocSummerNote.Controllers
{
    public class PostController : Controller
    {
        hocsummernoteDb db;
        // GET: Post
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Sử dụng cho HTTGEt
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult create()
        {

            return View();
        }

        /// <summary>
        /// Sử dụng cho HTTPPost
        /// </summary>
        /// <returns></returns>

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult create(post entity)
        {
            db = new hocsummernoteDb();
            db.posts.Add(entity);
            db.SaveChanges();
            return View();
        }


        [HttpPost]
        /// <summary>
        /// Phương thức này sẽ được gọi từ jQuery Ajax mỗi khi user chọn hình để chèn vao bài viết từ Summernote
        /// </summary>
        /// <param name="uploadFiles"></param>
        /// <returns></returns>
        public JsonResult uploadFile(HttpPostedFileBase uploadFiles)
        {
            string returnImagePath = string.Empty;
            string filename, extension, imageName, imageSavePath;
            if (uploadFiles.ContentLength > 0)
            {
                filename = Path.GetFileNameWithoutExtension(uploadFiles.FileName);
                extension = Path.GetExtension(uploadFiles.FileName);
                imageName = filename + DateTime.Now.ToString("yyyy_MM_dd_HHmmss");
                imageSavePath = Server.MapPath("/postedImage/") + imageName + extension;
                uploadFiles.SaveAs(imageSavePath);
                returnImagePath = "/postedImage/" + imageName + extension;
            }
            return Json(Convert.ToString(returnImagePath), JsonRequestBehavior.AllowGet);
        }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }
        
        /// <summary>
        /// 发布日期
        /// </summary>
        [Display(Name ="Release Data")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        /// <summary>
        /// 电影类型
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        [Column(TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }

    }
}

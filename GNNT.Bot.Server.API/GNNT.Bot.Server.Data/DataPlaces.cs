using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GNNT.Bot.Server.Model;
namespace GNNT.Bot.Server.Data
{
    public class DataPlaces
    {
        private List<MPlace> dataPlaces;
        public DataPlaces()
        {
            dataPlaces = new List<MPlace>();

            dataPlaces.Add
                (
                new MPlace
                {
                    askList = new List<Ask>
                    {
                        new Ask { Text = "Chỗ nào đi chơi ở Bình Dương ?" },
                        //new Ask { Text = "Chỗ nào đi chơi ở Bình Dương?" },
                        //new Ask { Text = "Cho nao di choi o binh duong?" }
                    },
                    answerlist = new List<Answer>
                    {
                        new Answer { Text = "Công viên thành phố mới" },
                        new Answer { Text = "Nhà thờ Phú Cường" },
                        new Answer { Text = "Quán café Gió & Nước" },
                        new Answer { Text = "Chùa Hội Khánh" },
                        new Answer { Text = "Chùa Tây Tạng" },
                        new Answer { Text = "Chùa Bà" },
                        new Answer { Text = "Chùa Châu Thới" },
                        new Answer { Text = "Hồ Bình An" },
                        new Answer { Text = "Khu du lịch Đại Nam"},
                        new Answer { Text = "Cụm du lịch Hồ Dầu Tiếng"},
                        new Answer { Text = "Làng nghề gốm sứ"},
                        new Answer { Text = "Làng sơn mài Tương Bình Hiệp"},
                        new Answer { Text = "Vườn trái cây Lái Thiêu"},
                        new Answer { Text = "Nhà thờ chánh tòa Phú Cường"},
                        new Answer { Text = "Chùa Châu Thới"},
                        new Answer { Text = "Chùa Thái Sơn"}
                    }
                }
                );
            //dataPlaces.Add
            //    (
            //    new MPlace
            //    {
            //        askList = new List<Ask>
            //        {
            //            new Ask { Text = "hello"}
            //        },
            //        answerlist = new List<Answer> { new Answer { Text = "I am Bot"} }
            //    }
            //    );
            dataPlaces.Add
                (
                new MPlace
                {
                    askList = new List<Ask>
                    {
                        new Ask { Text = "Công viên thành phố mới chỗ nào ?" }
                    },
                    answerlist = new List<Answer>
                    {
                    new Answer { Text = "Nằm trong khuôn viên thành phố mới, dự định là trung tâm hành chính mới của tỉnh Bình Dương, thay thế cho thành phố Thủ Dầu Một. Công viên được xây dựng theo tiêu chuẩn Singapore, là điểm nhấn cho khu vực thành phố mới. Đồng thời nơi đây cũng là địa điểm vui chơi, giải trí, dã ngoại đầy hấp dẫn và quy mô trong tương lai. Công viên này cũng được nhiều bạn khoái táy máy “ống kính” lựa chọn để có những shot hình cực đẹp và đầy lãng mạn" }
                    }
                }
            );


            dataPlaces.Add
                    (
                    new MPlace
                    {
                        askList = new List<Ask>
                        {
                new Ask { Text = "Nhà thờ Phú Cường chỗ nào ?" }
                            },
                        answerlist = new List<Answer>
                            {
                new Answer { Text = "Nhà thờ tọa lạc ngay số 104 đường Lạc Long Quân, P. Phú Cường, TP. Thủ Dầu Một, Bình Dương, gần vòng xoay ngã 6 Thủ Dầu Một. Đây là một trong những tòa thánh lớn nhất ở Bình Dương, được xây dựng theo phong cách gothic hiện đại khá độc đáo." }
                            }
                    }
                        );


            dataPlaces.Add
                    (
                    new MPlace
                    {
                        askList = new List<Ask>
                        {
                            new Ask { Text = "Quán café Gió & Nước chỗ nào ?" }
                        },
                        answerlist = new List<Answer>
                            {
                                new Answer { Text = "Một công trình tuy nằm trong con hẻm tại số 6/28T Khu 3 Phú Thọ, TP. Thủ Dầu Một nhưng đã giành được rất nhiều giải thưởng của Hội Kiến trúc sư Việt Nam và quốc tế. Quán café Gió và Nước là một điểm dừng chân thú vị và dư sức mê hoặc du khách." }
                            }
                    }
                    );


            dataPlaces.Add
                    (
                    new MPlace
                    {
                        askList = new List<Ask>
                        {
                new Ask { Text = "Chùa Hội Khánh chỗ nào ?" }
                            },
                        answerlist = new List<Answer>
                            {
                new Answer { Text = "Chùa Hội Khánh tọa lạc tại số 35 đường Yersin, phường Phú Cường, TP. Thủ Dầu Một, Bình Dương. Sở hữu pho tượng nằm độc đáo, chùa Hội Khánh từng nhận kỷ lục về tượng Phật nhập niết bàn nằm trên mái dài nhất châu Á. Với kích thước dài 52 m, cao 12 m nằm cách mặt đất 24 m, đây cũng là tượng Phật nằm dài nhất Việt Nam." }
                            }
                    }
                        );


            dataPlaces.Add
                    (
                    new MPlace
                    {
                        askList = new List<Ask>
                        {
                new Ask { Text = "Chùa Tây Tạng chỗ nào?" }
                            },
                        answerlist = new List<Answer>
                            {
                new Answer { Text = "Nằm ở Thủ Dầu Một, Bình Dương, chùa Tây Tạng lại thu hút du khách bằng bức tượng Đạt Ma Sư Tổ tết bằng tóc lớn nhất Việt Nam. Tượng cao 2,32 m, được tạo chủ yếu từ tóc của Phật tử, mật rỉ đường và vôi vữa. " }
                            }
                    }
                        );


            dataPlaces.Add
                    (
                    new MPlace
                    {
                        askList = new List<Ask>
                        {
                new Ask { Text = "Chùa Bà chỗ nào ?" }
                            },
                        answerlist = new List<Answer>
                            {
                new Answer { Text = "Chùa Bà Thiên Hậu ở Bình Dương (gọi tắt là chùa Bà Bình Dương) hay miếu bà Thiên Hậu, có tên chữ là Thiên Hậu Cung; hiện tọa lạc tại số 4 đường Nguyễn Du, TP. Thủ Dầu Một. Đây là ngôi miếu do các ban người Việt gốc Hoa tạo lập để thờ vị nữ thần là Thiên Hậu Thánh Mẫu" }
                            }
                    }
                        );


            dataPlaces.Add
                    (
                    new MPlace
                    {
                        askList = new List<Ask>
                        {
                new Ask { Text = "Chùa Châu Thới chỗ nào ?" }
                            },
                        answerlist = new List<Answer>
                            {
                new Answer { Text = "Chùa Châu Thới tọa lạc trên đỉnh núi Châu Thới, thuộc xã Bình An, huyện Dĩ An, là một trong những ngôi chùa cổ nhất của tỉnh Bình Dương. Những công trình kiến trúc Phật giáo độc đáo, vẻ đẹp yên bình, thoáng đãng của chùa thu hút nhiều khách thập phương đến viếng thăm." }
                            }
                    }
                        );


            dataPlaces.Add
                    (
                    new MPlace
                    {
                        askList = new List<Ask>
                        {
                new Ask { Text = "Hồ Bình An chỗ nào ?" }
                            },
                        answerlist = new List<Answer>
                            {
                new Answer { Text = "Hồ Bình An thuộc địa phận Ngãi Thắng, phường Bình Thắng, thị xã Dĩ An, Bình Dương. Đúng như tên gọi của nó, khung cảnh ở hồ rất bình yên, tĩnh lặng, phù hợp để nghỉ ngơi thư giãn. Hồ được bao quanh bởi những hàng cây tỏa bóng mát quanh năm, những bồn hoa khoe sắc bốn mùa." }
                            }
                    }
                        );


            dataPlaces.Add
                    (
                    new MPlace
                    {
                        askList = new List<Ask>
                        {
                new Ask { Text = "Khu du lịch Đại Nam chỗ nào ?" }
                            },
                        answerlist = new List<Answer>
                            {
                new Answer { Text = "Khu du lịch Đại Nam tọa lạc tại phường Hiệp An, TP. Thủ Dầu Một, cách thành phố Hồ Chí Minh khoảng 30km về phía Bắc. Toàn bộ khu du lịch có tổng diện tích khoảng 476ha, nơi đây tích hợp nhiều loại hình du lịch, vui chơi giải trí bao gồm đền đài, thành quách, núi non, khách sạn, sông hồ, khu vui chơi giải trí… là địa điểm du lịch tâm linh mang đậm văn hóa truyền thống của dân tộc." }
                            }
                    }
                        );


            dataPlaces.Add
                    (
                    new MPlace
                    {
                        askList = new List<Ask>
                        {
                new Ask { Text = "Hồ Dầu Tiếng chỗ nào ?" }
                            },
                        answerlist = new List<Answer>
                            {
                new Answer { Text = "Hồ Dầu Tiếng là khu danh thắng nổi tiếng của tỉnh Bình Dương. Nơi đây có núi, hồ và nước. Trong đó nổi bật hơn cả là Núi Cậu được ví là một bức tranh sơn thủy hữu tình. Đây là địa điểm du lịch lý thú dành cho du khách trong hành trình tìm về với thiên nhiên hoang dã. Đứng trên Núi Cậu bạn có thể quan sát cảnh đẹp xung quanh hồ Dầu Tiếng." }
                            }
                    }
                        );


            dataPlaces.Add
                    (
                    new MPlace
                    {
                        askList = new List<Ask>
                        {
                new Ask { Text = "Làng nghề gốm sứ chỗ nào ?" }
                            },
                        answerlist = new List<Answer>
                            {
                new Answer { Text = "Làng gốm sứ truyền thống của Bình Dương thuộc địa phận 3 xã gồm: xã Hưng Định, Thuận Giao, Bình Hòa thuộc thị xã Thuận An, Bình Dương và phường Chánh Nghĩa thuộc TP. Thủ Dầu Một với trên 500 lò gốm sứ." }
                            }
                    }
                        );


            dataPlaces.Add
                    (
                    new MPlace
                    {
                        askList = new List<Ask>
                        {
                new Ask { Text = "Làng sơn mài Tương Bình Hiệp chỗ nào ?" }
                            },
                        answerlist = new List<Answer>
                            {
                new Answer { Text = "Làng nghề truyền thống sơn mài Tương Bình Hiệp thuộc xã Tương Bình Hiệp, TP.Thủ Dầu Một, cách trung tâm thành phố khoảng 7km về phía Bắc. Từ lâu nơi đây vẫn nổi tiếng với nghề làm sơn mài uy tín, chất lượng và có giá trị nghệ thuật cao, được xuất khẩu ra một số nước trên thế giới và tham gia nhiều hội chợ triển lãm trong nước và quốc tế. " }
                            }
                    }
                        );


            dataPlaces.Add
                    (
                    new MPlace
                    {
                        askList = new List<Ask>
                        {
                new Ask { Text = "Nhà thờ chánh tòa Phú Cường chỗ nào ?" }
                            },
                        answerlist = new List<Answer>
                            {
                new Answer { Text = "Nhà thờ chánh tòa Phú Cường nằm ở số 104 Lạc Long Quân, phường Phú Cường, TP. Thủ Dầu Một, gần vòng xoay ngã 6 Thủ Dầu Một. Nhà thờ được xây dựng theo phong cách Gothic, uy nghiêm với những hàng ghế, tiếng chuông ngân nga và không gian yên tĩnh." }
                            }
                    }
                        );


            dataPlaces.Add
                    (
                    new MPlace
                    {
                        askList = new List<Ask>
                        {
                new Ask { Text = "Chùa Châu Thới chỗ nào ?" }
                            },
                        answerlist = new List<Answer>
                            {
                new Answer { Text = "Chùa Châu Thới tọa lạc trên đỉnh núi Châu Thới, thuộc xã Bình An, huyện Dĩ An, là một trong những ngôi chùa cổ nhất của tỉnh Bình Dương. Những công trình kiến trúc Phật giáo độc đáo, vẻ đẹp yên bình, thoáng đãng của chùa thu hút nhiều khách thập phương đến viếng thăm. " }
                            }
                    }
                        );


            dataPlaces.Add
                    (
                    new MPlace
                    {
                        askList = new List<Ask>
                        {
                new Ask { Text = "Chùa Thái Sơn chỗ nào ?" }
                            },
                        answerlist = new List<Answer>
                            {
                new Answer { Text = "Đến núi Cậu, chúng ta sẽ được vãn cảnh và thăm chùa Thái Sơn nằm lưng chừng núi ở độ cao khoảng 50 m. Chùa do hòa thượng Thích Đạt Phẩm (hay còn gọi là thầy Sáu) xây dựng vào năm 1988 với khuôn viên trên 5 ha, gồm các hạng mục như: cổng Tam Quan rất bề thế, lợp ngói xanh giả cổ, ngôi Cửu Trùng Đại Tháp cao 36 m có 9 tầng, tượng Nam Hải Quán Thế âm Bồ Tát cao 12 m, Chánh Điện, Điện Ngọc rất hoành tráng được xây dựng theo lối kiến trúc cổ lầu phương Đông. " }
                            }
                    }
                        );


            dataPlaces.Add
                    (
                    new MPlace
                    {
                        askList = new List<Ask>
                        {
                new Ask { Text = "Chùa Bà Thiên Hậu chỗ nào ?" }
                            },
                        answerlist = new List<Answer>
                            {
                new Answer { Text = "Chùa Bà Thiên Hậu ở Bình Dương (gọi tắt là chùa Bà Bình Dương) hay miếu bà Thiên Hậu, có tên chữ là Thiên Hậu Cung; hiện tọa lạc tại số 4 đường Nguyễn Du, thành phố Thủ Dầu Một, tỉnh Bình Dương. Đây là ngôi miếu do các ban người Việt gốc Hoa tạo lập để thờ vị nữ thần là Thiên Hậu Thánh Mẫu. " }
                            }
                    }
                        );


            dataPlaces.Add
                    (
                    new MPlace
                    {
                        askList = new List<Ask>
                        {
                new Ask { Text = "Biết Hồ Dầu Tiếng – Núi Cậu không?" }
                            },
                        answerlist = new List<Answer>
                            {
                new Answer { Text = "Quần thể núi Cậu với tổng diện tích hơn 1.600 ha, gồm 21 ngọn núi lớn nhỏ có dạng hình chữ U. Ngọn núi cao nhất là núi Cửa Ông cao 295 m, núi Ông cao 285 m, núi Tha La cao 198 m và núi thấp nhất là núi Chúa cao 63 m. Bốn ngọn núi này gắn liền với nhau tạo thành một dãy núi nhấp nhô kéo dài nằm chếch về hướng Bắc – Đông Bắc và Nam – Tây Nam. Núi Cậu mang vẻ đẹp thiên nhiên trù phú với nhiều loại gỗ quý như: Gõ, Căm xe, Giáng hương, Bằng lăng… và là nơi sinh sống của nhiều loài động vật như: Nai, Mễn, Heo rừng. Hồ Dầu Tiếng là một công trình thủy lợi lớn với diện tích rộng trên 27.000 ha chứa 1,5 tỷ m3 nước phục vụ cho sản xuất nông nghiệp. Đây là một hồ nước trong xanh, mặt hồ phẳng lặng, xung quanh hồ là những thảm cỏ xanh mượt, điểm xuyết những đóa hoa khoe sắc tỏa hương. Từ trên núi Cậu nhìn xuống quang cảnh hồ đẹp tựa như một bức tranh thủy mặc, sơn thủy hữu tình." }
                            }
                    }
                        );


            dataPlaces.Add
                    (
                    new MPlace
                    {
                        askList = new List<Ask>
                        {
                            new Ask { Text = "Biết Công viên nước Thanh Lễ không ?" },
                            //new Ask { Text = "Biết Công viên nước Thanh Lễ không " },
                            //new Ask { Text = "Biết Công viên nước Thanh Lễ không?" },
                            //new Ask { Text = "Biet cong vien nuoc Thanh Le khong ?" }
                            },
                        answerlist = new List<Answer>
                            {
                new Answer { Text = "Công viên có hồ thiếu nhi dành riêng cho trẻ em. Trẻ em đến đây có thể chơi các trò chơi với tàu chaỵ bằng hơi nước, các máng trượt nhỏ, các hình tượng nấm, rùa, cá sấu phun nước…phù hợp với lứa tuổi thiếu nhi. Ngoài ra công viên còn có hồ tạo sóng với nhiều chương trình chơi sóng hấp dẫn: sóng cao 0.9m và đợt sóng ngắn, sóng đơn, sóng kép, sóng đan xen…" }
                            }
                    }
                        );


            dataPlaces.Add
                    (
                    new MPlace
                    {
                        askList = new List<Ask>
                        {
                new Ask { Text = "Biết Khu du lịch Phương Nam không ?" }
                            },
                        answerlist = new List<Answer>
                            {
                new Answer { Text = "Địa chỉ: 15/12 Ấp Trung, Vĩnh Phú, Thuận An, Bình Dương, Việt Nam. Với diện tích trãi rộng trên 3 hecta, cách trung tâm các thành phố lớn như: TP.Hồ Chí Minh, TX Thủ Dầu Một, TP Biên Hòa với quãng đường 10 – 15km và chỉ cách các khu công nghiệp Việt Nam – Singapore, Việt Hương, Đồng An, Sóng Thần I, Sóng Thần II và Linh Trung… từ 5 – 10km. Khu du lịch Phương Nam như là một lá phổi xanh rất lý tưởng để quý khách cùng gia đình hoặc bạn bè đến nghỉ dưỡng, thư giãn và thưởng thức các món ngon đặc sản Âu – Hoa – Việt." }
                            }
                    }
                        );


            dataPlaces.Add
                    (
                    new MPlace
                    {
                        askList = new List<Ask>
                        {
                new Ask { Text = "Biết Khu du lịch Dìn Ký không ?" }
                            },
                        answerlist = new List<Answer>
                            {
                new Answer { Text = "Địa chỉ: 8/15 Quốc lộ 13, xã Vĩnh Phú, huyện Lái Thiêu, tỉnh Bình Dương. Khu du lịch xanh Dìn Ký resort chỉ cách trung tâm Sài Gòn 15km nhưng lại mang đậm dấu ấn làng quê. Cùng với lợi thế sông nước, vườn cây, nơi đây đang là điểm thư giãn lý tưởng của nhiều du khách có vốn thời gian nghỉ ngơi ít ỏi mong muốn có một kì nghỉ ngắn ngày thật thoải mái." }
                            }
                    }
                        );


            dataPlaces.Add
                    (
                    new MPlace
                    {
                        askList = new List<Ask>
                        {
                new Ask { Text = "Biết Sân Golf Sông Bé không?" }
                            },
                        answerlist = new List<Answer>
                            {
                new Answer { Text = "Địa chỉ: 77 Đại Lộ Bình Dương, thị Trấn Lái Thiêu, huyện Thuận An, Bình DươngWebsite: www.songbegolf.com. Sân Golf Sông Bé nằm trên 1 vị trí rất thuận lợi dọc theo đại lộ Bình Dương, chỉ cách trung tâm thành phố Hồ Chí Minh và sân bay Tân Sơn Nhất khoảng 40 phút lái xe. Hoạt động từ năm 1994, sân Golf Sông Bé là sân golf đầu tiên đạt tiêu chuẩn cho giải Vô địch quốc tế tại Việt Nam, đồng thời cũng nổi tiếng là sân golf tạo nhiều cảm giác thú vị và thử thách nhất." }
                            }
                    }
                        );


            dataPlaces.Add
                    (
                    new MPlace
                    {
                        askList = new List<Ask>
                        {
                new Ask { Text = "Biết Sân Golf Phú Mỹ không bot ?" }
                            },
                        answerlist = new List<Answer>
                            {
                new Answer { Text = "Địa chỉ: Số 68 Trần Ngọc Lên, Phường Định Hòa, Thị xã Thủ Dầu Một, tỉnh Bình Dương. Cách Thành phố Hồ Chí Minh 32 km về phía Bắc, theo quốc lộ 13. Mất 55 phút đi xe từ trung tâm thành phố Hồ Chí Minh và 55 phút đi xe từ sân bay quốc tế Tân Sơn Nhất.Sân gôn 27 lỗ này đã được khánh thành và đưa vào hoạt động từ tháng 12 năm 2011 nằm trong top 10 các sân golf Việt Nam được Hiệp hội Golf Việt Nam bình chọn năm 2011." }
                            }
                    }
                        );


            dataPlaces.Add
                    (
                    new MPlace
                    {
                        askList = new List<Ask>
                        {
                new Ask { Text = "Biết Khu du lịch Thủy Châu không ?" }
                            },
                        answerlist = new List<Answer>
                            {
                new Answer { Text = "Chỉ cách trung tâm Sài Gòn 20km (ngã 3 Tân Vạn) đến nhà hàng sân vườn Pacific quý khách sẽ gặp một Trường Sơn thu nhỏ với hình dáng đường nét của đồi núi, có cây xanh mượt mà bao phủ, có thác reo suối chảy, có chim kêu vượn hót như thực như hư thật lãng mạn nên thơ. Khu du lịch Thủy Châu – Nhà hàng sân vườn Pacific đáp ứng đủ tiêu chí: không gian xanh, rộng rãi – đồ ăn ngon rẻ, thích hợp cho các hoạt động vui chơi, cắm trại, sinh hoạt, dã ngoại cuối tuần" }
                            }
                    }
                        );


            dataPlaces.Add
                    (
                    new MPlace
                    {
                        askList = new List<Ask>
                        {
                new Ask { Text = "Biết Chợ đêm và phố đi bộ Bạch Đằng không ?" }
                            },
                        answerlist = new List<Answer>
                            {
                new Answer { Text = "Chợ đêm Bạch Đằng chính thức khai trương ngày 25/8, hoạt động từ 17 đến 23 giờ 30 phút hàng ngày, với gần 338 gian hàng, chuyên kinh doanh quần áo may sẵn, giày dép, nón, mỹ phẩm, trang sức, phụ kiện thời trang… Chợ cũng phục vụ nhiều món ăn dân dã địa phương với các món ăn đặc sản vùng miền. Ngoài ra, chợ cũng có khu trò chơi giải trí lành mạnh cho các cháu thiếu nhi." }
                            }
                    }
                        );


            dataPlaces.Add
                    (
                    new MPlace
                    {
                        askList = new List<Ask>
                        {
                new Ask { Text = "Biết Làng Tre Phú An không ?" }
                            },
                        answerlist = new List<Answer>
                            {
                new Answer { Text = "Được hình thành từ năm 1999 trên ý tưởng khoa học của Tiến sĩ Diệp Thị Mỹ Hạnh, giảng viên trường Đại học Khoa học Tự nhiên TP. Hồ Chí Minh với sự hợp tác giữa 4 đơn vị: vùng Rhône Alpes (Pháp), Ủy ban nhân dân tỉnh Bình Dương, Vườn thiên nhiên Pilat (Pháp) và trường Đại học Khoa học Tự nhiên TP. Hồ Chí Minh, Làng tre Phú An bao gồm: Bảo tàng Sinh thái tre và Bảo tồn Thực vật Phú An, là nơi tập trung khoảng 1.500 bụi tre với hơn 300 mẫu tre, trúc, nứa thuộc 17 giống, chiếm gần 90% giống tre ở Việt Nam, trong đó có nhiều giống quý hiếm như Phyllostachys, Bambusa, Teinostachyum, mai ống, vàng sọc, tre ngà…" }
                            }
                    }
                        );


            dataPlaces.Add
                    (
                    new MPlace
                    {
                        askList = new List<Ask>
                        {
                new Ask { Text = "Biết AEON MALL Bình Dương Canary không ?" }
                            },
                        answerlist = new List<Answer>
                            {
                new Answer { Text = "Là Trung tâm thương mại mang phong cách Nhật Bản, là khu phức hợp mua sắm, vui chơi, giải trí và thưởng thức nét tinh hoa ẩm thực Nhật Bản ngay tại Bình Dương . Với diện tích hơn 70.000 m2, trung tâm thương mại AEON MALL Bình Dương Canary là một trung tâm phức hợp với nhiều tiện ích hoàn hảo dành cho gia đình như siêu thị, cửa hàng mỹ phẩm, thời trang, đồ gia dụng, nhà hàng, rạp chiếu phim, khu vui chơi thiếu nhi, bowling, trung tâm toán học, trung tâm thể dục thể hình,… cùng với hơn 118 cửa hàng bày bán các sản phẩm chất lượng cao và một khu ẩm thực độc đáo với những món ăn tinh tế mang đậm phong cách ẩm thực truyền thống Nhật Bản." }
                            }
                    }
                        );
            dataPlaces.Add
                    (
                    new MPlace
                    {
                        askList = new List<Ask>
                        {
                            new Ask { Text = "Hello" }
                        },
                        answerlist = new List<Answer>
                        {
                            new Answer { Text = "Hi!" },
                            new Answer { Text = "i am bot chat place" },
                            new Answer { Text = "Can me help you?" }
                        }
                    }
                        );


        }
        public List<MPlace> ReturnData()
        {
            return dataPlaces;
        }
    }
}

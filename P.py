from lxml import etree
import requests
import os, sys
from bs4 import BeautifulSoup

headers = {"User-Agent": 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) '
                         'AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36'
           }
Top = 1

# 先创建文件夹
print("开始创建文件夹……")
for r in range(250):
    v_foleder = "D://豆瓣top250"
    Vname_list = os.listdir(v_foleder)

    # 指定路径创建新文件夹
    file_path = 'D:/豆瓣top250' + "/" + str(r + 1)
    r = r + 1
    if not os.path.exists(file_path):  # 判断文件夹是否已经存在
        os.mkdir(file_path)
    else:
        print(file_path + ' 目录已存在')
print("创建文件夹完成")


# 获取文本信息
def getHTMLText(url):
    try:
        r = requests.get(url, headers=headers, timeout=30)
        r.raise_for_status()
        r.encoding = r.apparent_encoding
        return r.text
    except:
        return '产生异常'


def getInfo(url):
    html = requests.get(url, headers=headers, timeout=30)
    # print(html.status_code)
    root = etree.HTML(html.content)

    # <div class="info">
    for InformationBlock in root.xpath('//div[@class="info"]'):
        # 影片名称
        title = InformationBlock.xpath('div[@class="hd"]/a/span[@class="title"]/text()')[0]
        # print(title)

        # <div class="bd">块，导演、演员、上映时间、制片国家、影片类型在一个<p>里
        info = InformationBlock.xpath('div[@class="bd"]/p[1]/text()')
        # print(type(info))

        # 导演和主演
        try:
            directorandStar = info[0].replace(" ", "").replace("\n", "").replace(".", "").split("/")[0]
        except:
            directorandStar = " "

        # 上映日期
        date = "上映日期：" + info[1].replace(" ", "").replace("\n", "").split("/")[0]

        # 制片国家
        country = "制片国家：" + info[1].replace("", "").replace("\n", "").split("/")[1]

        # 影片类型
        geners = "影片类型：" + info[1].replace("", "").replace("\r\n", "").split("/")[2]

        # 评分
        rate = "评分：" + InformationBlock.xpath('div[@class="bd"]/div/span[2]/text()')[0]

        # 评论人数
        comCount = "评论人数：" + InformationBlock.xpath('div[@class="bd"]/div/span[4]/text()')[0]

        # 寄语
        try:
            quote = "寄语：" + InformationBlock.xpath('div[@class="bd"]/p[2]/span[1]/text()')[0]
        except:
            quote = " "

        global Top
        # shell显示进度
        print(Top, title, directorandStar, rate, date, country, geners, comCount, quote)
        print("---------------------------------------------------------")

        datas = (
            ("{},{},{},{},{},{},{},{},{}").format(Top, title, directorandStar, rate, date, country, geners, comCount,
                                                  quote))

        base = 'D://豆瓣top250' + "//" + str(Top)
        path = base + "//" + title + ".txt"
        with open(path, "w", newline="", encoding="utf_8_sig") as f:
            f.write(datas)

        Top += 1


# 翻页
def nextPage():
    for i in range(0, 250, 25):
        url = 'https://movie.douban.com/top250?start={}&filter='.format(i)
        getInfo(url)


# 创建txt
if __name__ == '__main__':
    # 给文件加头部标题
    with open('D://豆瓣top250//包含内容.txt', "w", newline="", encoding="utf_8_sig") as f:
        f.write("Top,title,directorandStar,rate,date,country,geners,comCount,quote" + "\n")
    nextPage()

# 创建jpg
if __name__ == '__main__':
    i = 0
    urls = ['https://movie.douban.com/top250?start=' + str(n) + '&filter=' for n in range(0, 250, 25)]
    for url in urls:
        r = getHTMLText(url)
        soup = BeautifulSoup(r, 'html.parser')
        titles = soup.select('div.hd a')
        rates = soup.select('span.rating_num')
        pics = soup.select('img[width="100"]')
        for title, rate, pic in zip(titles, rates, pics):
            data = {'title': list(title.stripped_strings),
                    'rate': rate.get_text(),
                    'pic': pic.get('src')}
            i += 1
            middlename = str(i) + "//"
            fileName = data['title'][0] + '.jpg'
            pic1 = requests.get(data['pic'])
            with open("D://豆瓣top250//" + middlename + fileName, 'wb') as photo:
                photo.write(pic1.content)
                # shell显示进度
                print("图片" + str(i) + "下载完成")




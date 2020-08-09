﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AntDesign.Docs.Services
{
   public  class IconsService
    {
        public async  Task<List<IconItem>> GetIconsAsync()
        {
            List<IconItem> icons = new List<IconItem>();

            var item1 = new IconItem()
            {
                Category = "direction",
                IconNames = new List<string> {
                            "step-backward",
                            "step-forward",
                            "fast-backward",
                            "fast-forward",
                            "shrink",
                            "arrows-alt",
                            "down",
                            "up",
                            "left",
                            "right",
                            "caret-up",
                            "caret-down",
                            "caret-left",
                            "caret-right",
                            "up-circle",
                            "down-circle",
                            "left-circle",
                            "right-circle",
                            "double-right",
                            "double-left",
                            "vertical-left",
                            "vertical-right",
                            "vertical-align-top",
                            "vertical-align-middle",
                            "vertical-align-bottom",
                            "forward",
                            "backward",
                            "rollback",
                            "enter",
                            "retweet",
                            "swap",
                            "swap-left",
                            "swap-right",
                            "arrow-up",
                            "arrow-down",
                            "arrow-left",
                            "arrow-right",
                            "play-circle",
                            "up-square",
                            "down-square",
                            "left-square",
                            "right-square",
                            "login",
                            "logout",
                            "menu-fold",
                            "menu-unfold",
                            "border-bottom",
                            "border-horizontal",
                            "border-inner",
                            "border-outer",
                            "border-left",
                            "border-right",
                            "border-top",
                            "border-verticle",
                            "pic-center",
                            "pic-left",
                            "pic-right",
                            "radius-bottomleft",
                            "radius-bottomright",
                            "radius-upleft",
                            "radius-upright",
                            "fullscreen",
                            "fullscreen-exit",
                            "star"
                    }
            };

            var item2 = new IconItem()
            {
                Category = "suggestion",
                IconNames = new List<string>{
                                            "question",
                                            "question-circle",
                                            "plus",
                                            "plus-circle",
                                            "pause",
                                            "pause-circle",
                                            "minus",
                                            "minus-circle",
                                            "plus-square",
                                            "minus-square",
                                            "info",
                                            "info-circle",
                                            "exclamation",
                                            "exclamation-circle",
                                            "close",
                                            "close-circle",
                                            "close-square",
                                            "check",
                                            "check-circle",
                                            "check-square",
                                            "clock-circle",
                                            "warning",
                                            "issues-close",
                                            "stop"
                                        }
            };

            var item3 = new IconItem()
            {
                Category = "edit",
                IconNames = new List<string>
                        {
                            "edit",
                            "form",
                            "copy",
                            "scissor",
                            "delete",
                            "snippets",
                            "diff",
                            "highlight",
                            "align-center",
                            "align-left",
                            "align-right",
                            "bg-colors",
                            "bold",
                            "italic",
                            "underline",
                            "strikethrough",
                            "redo",
                            "undo",
                            "zoom-in",
                            "zoom-out",
                            "font-colors",
                            "font-size",
                            "line-height",
                            "colum-height",
                            "colum-width",
                            "dash",
                            "small-dash",
                            "sort-ascending",
                            "sort-descending",
                            "drag",
                            "ordered-list",
                            "unordered-list",
                            "radius-setting",
                            "column-width"
                        }
             };

            var item4 = new IconItem()
            {
                Category = "data",
                IconNames = new List<string>
                {
                      "area-chart",
                        "pie-chart",
                        "bar-chart",
                        "dot-chart",
                        "line-chart",
                        "radar-chart",
                        "heat-map",
                        "fall",
                        "rise",
                        "stock",
                        "box-plot",
                        "fund",
                        "sliders"
                }
            };

            var item5 = new IconItem()
            {
                Category = "logo",
                IconNames = new List<string>
                {
                    "android",
                    "apple",
                    "windows",
                    "ie",
                    "chrome",
                    "github",
                    "aliwangwang",
                    "dingding",
                    "weibo-square",
                    "weibo-circle",
                    "taobao-circle",
                    "html5",
                    "weibo",
                    "twitter",
                    "wechat",
                    "youtube",
                    "alipay-circle",
                    "taobao",
                    "skype",
                    "qq",
                    "medium-workmark",
                    "gitlab",
                    "medium",
                    "linkedin",
                    "google-plus",
                    "dropbox",
                    "facebook",
                    "codepen",
                    "code-sandbox",
                    "code-sandbox-circle",
                    "amazon",
                    "google",
                    "codepen-circle",
                    "alipay",
                    "ant-design",
                    "ant-cloud",
                    "aliyun",
                    "zhihu",
                    "slack",
                    "slack-square",
                    "behance",
                    "behance-square",
                    "dribbble",
                    "dribbble-square",
                    "instagram",
                    "yuque",
                    "alibaba",
                    "yahoo",
                    "reddit",
                    "sketch"
                }
            };

            icons.Add(item1);
            icons.Add(item2);
            icons.Add(item3);
            icons.Add(item4);
            icons.Add(item5);

            return icons;
        }

        public async Task<List<IconItem>> FindAll(string word)
        {
            var listOfIcons = await GetIconsAsync();
            List<IconItem> lstNewIcons = new List<IconItem>();
            foreach (var item in listOfIcons)
            {
                var icons = item.IconNames.FindAll(a => a.ToLower().Contains(word));
                if (icons.Count == 0) continue;

                lstNewIcons.Add(new IconItem
                {
                    Category = item.Category,
                    IconNames = icons
                });
            }

            return lstNewIcons;
        }

    }

    public class IconItem
    {
        public string Category { get; set; }
        public List<string> IconNames { get; set; }
    }


}

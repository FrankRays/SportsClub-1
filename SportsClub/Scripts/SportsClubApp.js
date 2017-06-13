(function () {

    var themes = {
        "default": "/Content/bootstrap.min.css",
        "amelia": "//bootswatch.com/amelia/bootstrap.min.css",
        "cerulean": "//bootswatch.com/cerulean/bootstrap.min.css",
        "cosmo": "//bootswatch.com/cosmo/bootstrap.min.css",
        "cyborg": "//bootswatch.com/cyborg/bootstrap.min.css",
        "flatly": "//bootswatch.com/flatly/bootstrap.min.css",
        "journal": "//bootswatch.com/journal/bootstrap.min.css",
        "readable": "//bootswatch.com/readable/bootstrap.min.css",
        "simplex": "//bootswatch.com/simplex/bootstrap.min.css",
        "slate": "//bootswatch.com/slate/bootstrap.min.css",
        "spacelab": "//bootswatch.com/spacelab/bootstrap.min.css",
        "united": "//bootswatch.com/united/bootstrap.min.css",
        "darky": "/Content/Themes/darky.min.css"
    }

    $(function () {
        var themesheet = $('<link href="' + themes['default'] + '" rel="stylesheet" />');
        themesheet.appendTo('head');
        $('#theme-dropdown a').click(function () {
            //var themeurl = themes[$(this).attr('data-theme')];
            var themeurl = themes[this.innerText];
            themesheet.attr('href', themeurl);
        });

        $('#contientdropdown').text($("#SelectedContinent").val());
    });

})()




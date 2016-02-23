function TheCodeAttic_CollapseAll() {
    jQuery('.scEditorSectionCaptionExpanded').each(function (index, e) {
        jQuery(e).attr("class", "scEditorSectionCaptionCollapsed");
        jQuery(e).next().css("display", "none");

        var objectId = jQuery(e).attr("id");

        var glyph = document.getElementById(objectId + "_Glyph");
        if (glyph != null) {
            var replace = "/accordion_up";
            var replaceWith = "/accordion_down";

            scForm.browser.setOuterHtml(glyph, scForm.browser.getOuterHtml(glyph).replace(replace, replaceWith));
        }
    });
}

function TheCodeAttic_ExpandAll() {
    jQuery('.scEditorSectionCaptionCollapsed').each(function (index, e) {

        jQuery(e).attr("class", "scEditorSectionCaptionExpanded");
        jQuery(e).next().slideToggle(100);
        var objectId = jQuery(e).attr("id");

        var glyph = document.getElementById(objectId + "_Glyph");
        if (glyph != null) {
            var replaceWith = "/accordion_up";
            var replace = "/accordion_down";

            scForm.browser.setOuterHtml(glyph, scForm.browser.getOuterHtml(glyph).replace(replace, replaceWith));
        }
    });
}
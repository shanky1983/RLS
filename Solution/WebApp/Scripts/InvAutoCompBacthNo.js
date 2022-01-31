 
 
function actb(obj, ca) {
    /* ---- Public Variables ---- */
    this.actb_timeOut = -1; // Autocomplete Timeout in ms (-1: autocomplete never time out)
    this.actb_lim = 4;    // Number of elements autocomplete can show (-1: no limit)
    this.actb_firstText = false; // should the auto complete be limited to the beginning of keyword?
    this.actb_mouse = true; // Enable Mouse Support
    this.actb_delimiter = new Array(';', ',');  // Delimiter for multiple autocomplete. Set it to empty array for single autocomplete
    this.actb_startcheck = 1; // Show widget only after this number of characters is typed in.
    /* ---- Public Variables ---- */

    /* --- Styles --- */
    this.actb_bgColor = '#888888';
    this.actb_fwidth = '93px';
    this.actb_textColor = '#FFFFFF';
    this.actb_hColor = '#000000';
    this.actb_fFamily = 'Verdana';
    this.actb_fSize = '11px';
    this.actb_hStyle = 'text-decoration:underline;font-weight="bold"';
    /* --- Styles --- */

    /* ---- Private Variables ---- */
    var actb_delimwords = new Array();
    var actb_cdelimword = 0;
    var actb_delimchar = new Array();
    var actb_display = false;
    var actb_pos = 0;
    var actb_total = 0;
    var actb_curr = null;
    var actb_rangeu = 0;
    var actb_ranged = 0;
    var actb_bool = new Array();
    var actb_pre = 0;
    var actb_toid;
    var actb_tomake = false;
    var actb_getpre = "";
    var actb_mouse_on_list = 1;
    var actb_kwcount = 0;
    var actb_caretmove = false;
    this.actb_keywords = new Array();
    /* ---- Private Variables---- */

    this.actb_keywords = ca;
    var actb_self = this;

    actb_curr = obj;

    addEvent(actb_curr, "focus", actb_setup);
    function actb_setup() {
        addEvent(document, "keydown", actb_checkkey);
        addEvent(actb_curr, "blur", actb_clear);
        addEvent(document, "keypress", actb_keypress);
    }

    function actb_clear(evt) {
        if (!evt) evt = event;
        removeEvent(document, "keydown", actb_checkkey);
        removeEvent(actb_curr, "blur", actb_clear);
        removeEvent(document, "keypress", actb_keypress);
        actb_removedisp();
    }
    function actb_parse(n) {
        if (actb_self.actb_delimiter.length > 0) {
            var t = actb_delimwords[actb_cdelimword].trim().addslashes();
            var plen = actb_delimwords[actb_cdelimword].trim().length;
        } else {
            var t = actb_curr.value.addslashes();
            var plen = actb_curr.value.length;
        }
        var tobuild = '';
        var i;

        if (actb_self.actb_firstText) {
            var re = new RegExp("^" + t, "i");
        } else {
            var re = new RegExp(t, "i");
        }
        var p = n.search(re);

        for (i = 0; i < p; i++) {
            tobuild += n.substr(i, 1);
        }
        tobuild += "<font style='" + (actb_self.actb_hStyle) + "'>"
        for (i = p; i < plen + p; i++) {
            tobuild += n.substr(i, 1);
        }
        tobuild += "</font>";
        for (i = plen + p; i < n.length; i++) {
            tobuild += n.substr(i, 1);
        }
        return tobuild;
    }
    function actb_generate() {

        if (document.getElementById('tat_table')) { actb_display = false; document.body.removeChild(document.getElementById('tat_table')); }
        if (actb_kwcount == 0) {
            actb_display = false;
            return;
        }
        a = document.createElement('table');
        a.cellSpacing = '1px';
        a.cellPadding = '2px';
        a.style.position = 'absolute';
        a.style.top = eval(curTop(actb_curr) + actb_curr.offsetHeight) + "px";
        a.style.left = curLeft(actb_curr) + "px";
        a.style.backgroundColor = actb_self.actb_bgColor;
        a.style.width = actb_self.actb_fwidth;
        a.id = 'tat_table';
        document.body.appendChild(a);
        if (actb_curr.value.length > 1) {
            document.getElementById('tat_table').style.display = 'block';
        }
        if (actb_curr.value.length < 1) {
            document.getElementById('tat_table').style.display = 'none';
            return;
        }


        var i;
        var first = true;
        var j = 1;
        if (actb_self.actb_mouse) {
            a.onmouseout = actb_table_unfocus;
            a.onmouseover = actb_table_focus;
        }
        var counter = 0;
        for (i = 0; i < actb_self.actb_keywords.length; i++) {
            if (actb_bool[i]) {
                counter++;
                r = a.insertRow(-1);
                if (first && !actb_tomake) {
                    r.style.backgroundColor = actb_self.actb_hColor;
                    first = false;
                    actb_pos = counter;
                } else if (actb_pre == i) {
                    r.style.backgroundColor = actb_self.actb_hColor;
                    first = false;
                    actb_pos = counter;
                } else {
                    r.style.backgroundColor = actb_self.actb_bgColor;
                    r.style.width = actb_self.actb_fwidth;
                }
                r.id = 'tat_tr' + (j);
                c = r.insertCell(0);
                c.style.color = actb_self.actb_textColor;
                c.style.fontFamily = actb_self.actb_fFamily;
                c.style.fontSize = actb_self.actb_fSize;
                c.innerHTML = actb_parse(actb_self.actb_keywords[i].split("@#$")[0]);
                c.id = 'tat_td' + (j);
                c.setAttribute('pos', j);
                if (actb_self.actb_mouse) {
                    c.style.cursor = 'pointer';
                    c.onclick = actb_mouseclick;
                    c.onmouseover = actb_table_highlight;
                }
                q = r.insertCell(1);
                q.style.color = actb_self.actb_textColor;
                q.style.fontFamily = actb_self.actb_fFamily;
                q.style.fontSize = actb_self.actb_fSize;
                q.style.display = "none";
                q.innerHTML = actb_keywords[i].split("@#$")[1];
                q.id = 'tat_td' + (j);
                q.setAttribute('pos', j);
                if (actb_self.actb_mouse) {
                    q.style.cursor = 'pointer';
                    q.onclick = actb_mouseclick;
                    q.onmouseover = actb_table_highlight;
                }
                j++;
            }
            if (j - 1 == actb_self.actb_lim && j < actb_total) {
                r = a.insertRow(-1);
                r.style.backgroundColor = actb_self.actb_bgColor;
                r.style.width = actb_self.actb_fwidth;
                c = r.insertCell(0);
                c.style.color = actb_self.actb_textColor;
                c.style.fontFamily = 'arial narrow';
                c.style.fontSize = actb_self.actb_fSize;
                c.align = 'center';
                replaceHTML(c, '\\/');
                if (actb_self.actb_mouse) {
                    c.style.cursor = 'pointer';
                    c.onclick = actb_mouse_down;
                }
                break;
            }
        }
        actb_rangeu = 1;
        actb_ranged = j - 1;
        actb_display = true;
        if (actb_pos <= 0) actb_pos = 1;
    }
    function actb_remake() {
        document.body.removeChild(document.getElementById('tat_table'));
        a = document.createElement('table');
        a.cellSpacing = '1px';
        a.cellPadding = '2px';
        a.style.position = 'absolute';
        a.style.top = eval(curTop(actb_curr) + actb_curr.offsetHeight) + "px";
        a.style.left = curLeft(actb_curr) + "px";
        a.style.backgroundColor = actb_self.actb_bgColor;
        a.style.width = actb_self.actb_fwidth;
        a.id = 'tat_table';
        if (actb_self.actb_mouse) {
            a.onmouseout = actb_table_unfocus;
            a.onmouseover = actb_table_focus;
        }
        document.body.appendChild(a);
        var i;
        var first = true;
        var j = 1;
        if (actb_rangeu > 1) {
            r = a.insertRow(-1);
            r.style.backgroundColor = actb_self.actb_bgColor;
            r.style.width = actb_self.actb_fwidth;
            c = r.insertCell(0);
            c.style.color = actb_self.actb_textColor;
            c.style.fontFamily = 'arial narrow';
            c.style.fontSize = actb_self.actb_fSize;
            c.align = 'center';
            replaceHTML(c, '/\\');
            if (actb_self.actb_mouse) {
                c.style.cursor = 'pointer';
                c.onclick = actb_mouse_up;
            }
        }
        for (i = 0; i < actb_self.actb_keywords.length; i++) {
            if (actb_bool[i]) {
                if (j >= actb_rangeu && j <= actb_ranged) {
                    r = a.insertRow(-1);
                    r.style.backgroundColor = actb_self.actb_bgColor;
                    r.style.width = actb_self.actb_fwidth;
                    r.id = 'tat_tr' + (j);
                    c = r.insertCell(0);
                    c.style.color = actb_self.actb_textColor;
                    c.style.fontFamily = actb_self.actb_fFamily;
                    c.style.fontSize = actb_self.actb_fSize;
                    c.innerHTML = actb_parse(actb_self.actb_keywords[i].split("@#$")[0]);
                    c.id = 'tat_td' + (j);
                    c.setAttribute('pos', j);
                    if (actb_self.actb_mouse) {
                        c.style.cursor = 'pointer';
                        c.onclick = actb_mouseclick;
                        c.onmouseover = actb_table_highlight;
                    }
                    q = r.insertCell(1);
                    q.style.color = actb_self.actb_textColor;
                    q.style.fontFamily = actb_self.actb_fFamily;
                    q.style.fontSize = actb_self.actb_fSize;
                    q.style.display = "none";
                    q.innerHTML = actb_keywords[i].split("@#$")[1];
                    q.id = 'tat_td' + (j);
                    q.setAttribute('pos', j);
                    if (actb_self.actb_mouse) {
                        q.style.cursor = 'pointer';
                        q.onclick = actb_mouseclick;
                        q.onmouseover = actb_table_highlight;
                    }
                    j++;
                } else {
                    j++;
                }
            }
            if (j > actb_ranged) break;
        }
        if (j - 1 < actb_total) {
            r = a.insertRow(-1);
            r.style.backgroundColor = actb_self.actb_bgColor;
            r.style.width = actb_self.actb_fwidth;
            c = r.insertCell(0);
            c.style.color = actb_self.actb_textColor;
            c.style.fontFamily = 'arial narrow';
            c.style.fontSize = actb_self.actb_fSize;
            c.align = 'center';
            replaceHTML(c, '\\/');
            if (actb_self.actb_mouse) {
                c.style.cursor = 'pointer';
                c.onclick = actb_mouse_down;
            }
        }
    }
    function actb_goup() {
        if (!actb_display) return;
        if (actb_pos == 1) return;

        document.getElementById('tat_tr' + actb_pos).style.backgroundColor = actb_self.actb_bgColor;
        document.getElementById('tat_tr' + actb_pos).style.width = actb_self.actb_fwidth;
        actb_pos--;
        if (actb_pos < actb_rangeu) actb_moveup();
        document.getElementById('tat_tr' + actb_pos).style.backgroundColor = actb_self.actb_hColor;
        var pCell = document.getElementById('tat_tr' + actb_pos).cells[1].innerText;


        for (var j = 0; j < document.getElementById('tbllist').rows.length; j++) {
            document.getElementById('tbllist').rows[j].style.backgroundColor = "";
            if ("tr_par" + pCell == document.getElementById('tbllist').rows[j].id) {
                document.getElementById('tbllist').rows[j].style.backgroundColor = '#DCFC5C';
            }

        }

        if (actb_toid) clearTimeout(actb_toid);
        if (actb_self.actb_timeOut > 0) actb_toid = setTimeout(function() { actb_mouse_on_list = 0; actb_removedisp(); }, actb_self.actb_timeOut);
    }
    function actb_godown() {
        if (!actb_display) return;
        if (actb_pos == actb_total) return;
        document.getElementById('tat_tr' + actb_pos).style.backgroundColor = actb_self.actb_bgColor;
        document.getElementById('tat_tr' + actb_pos).style.width = actb_self.actb_fwidth;

        actb_pos++;
        if (actb_pos > actb_ranged) actb_movedown();
        document.getElementById('tat_tr' + actb_pos).style.backgroundColor = actb_self.actb_hColor;
        var pCell = document.getElementById('tat_tr' + actb_pos).cells[1].innerText;
        for (var j = 0; j < document.getElementById('tbllist').rows.length; j++) {
            document.getElementById('tbllist').rows[j].style.backgroundColor = "";
            if ("tr_par" + pCell == document.getElementById('tbllist').rows[j].id) {
                document.getElementById('tbllist').rows[j].style.backgroundColor = '#DCFC5C';
            }

        }
        if (actb_toid) clearTimeout(actb_toid);
        if (actb_self.actb_timeOut > 0) actb_toid = setTimeout(function() { actb_mouse_on_list = 0; actb_removedisp(); }, actb_self.actb_timeOut);
    }
    function actb_movedown() {
        actb_rangeu++;
        actb_ranged++;
        actb_remake();
    }
    function actb_moveup() {
        actb_rangeu--;
        actb_ranged--;
        actb_remake();
    }

    /* Mouse */
    function actb_mouse_down() {
        document.getElementById('tat_tr' + actb_pos).style.backgroundColor = actb_self.actb_bgColor;
        document.getElementById('tat_tr' + actb_pos).style.width = actb_self.actb_fwidth;

        actb_pos++;
        actb_movedown();
        document.getElementById('tat_tr' + actb_pos).style.backgroundColor = actb_self.actb_hColor;
        var pCell = document.getElementById('tat_tr' + actb_pos).cells[1].innerText;

        for (var j = 0; j < document.getElementById('tbllist').rows.length; j++) {
            document.getElementById('tbllist').rows[j].style.backgroundColor = "";
            if ("tr_par" + pCell == document.getElementById('tbllist').rows[j].id) {
                document.getElementById('tbllist').rows[j].style.backgroundColor = '#DCFC5C';
            }

        }
        actb_curr.focus();
        actb_mouse_on_list = 0;
        if (actb_toid) clearTimeout(actb_toid);
        if (actb_self.actb_timeOut > 0) actb_toid = setTimeout(function() { actb_mouse_on_list = 0; actb_removedisp(); }, actb_self.actb_timeOut);
    }
    function actb_mouse_up(evt) {
        if (!evt) evt = event;
        if (evt.stopPropagation) {
            evt.stopPropagation();
        } else {
            evt.cancelBubble = true;
        }
        document.getElementById('tat_tr' + actb_pos).style.backgroundColor = actb_self.actb_bgColor;
        document.getElementById('tat_tr' + actb_pos).style.width = actb_self.actb_fwidth;

        actb_pos--;
        actb_moveup();
        document.getElementById('tat_tr' + actb_pos).style.backgroundColor = actb_self.actb_hColor;
        var pCell = document.getElementById('tat_tr' + actb_pos).cells[1].innerText;


        for (var j = 0; j < document.getElementById('tbllist').rows.length; j++) {
            document.getElementById('tbllist').rows[j].style.backgroundColor = "";
            if ("tr_par" + pCell == document.getElementById('tbllist').rows[j].id) {
                document.getElementById('tbllist').rows[j].style.backgroundColor = '#DCFC5C';
            }

        }
        actb_curr.focus();
        actb_mouse_on_list = 0;
        if (actb_toid) clearTimeout(actb_toid);
        if (actb_self.actb_timeOut > 0) actb_toid = setTimeout(function() { actb_mouse_on_list = 0; actb_removedisp(); }, actb_self.actb_timeOut);
    }
    function actb_mouseclick(evt) {
        if (!evt) evt = event;
        if (!actb_display) return;
        actb_mouse_on_list = 0;
        actb_pos = this.getAttribute('pos');
        actb_penter();
    }
    function actb_table_focus() {
        actb_mouse_on_list = 1;
    }
    function actb_table_unfocus() {
        actb_mouse_on_list = 0;
        if (actb_toid) clearTimeout(actb_toid);
        if (actb_self.actb_timeOut > 0) actb_toid = setTimeout(function() { actb_mouse_on_list = 0; actb_removedisp(); }, actb_self.actb_timeOut);
    }
    function actb_table_highlight() {
        actb_mouse_on_list = 1;
        document.getElementById('tat_tr' + actb_pos).style.backgroundColor = actb_self.actb_bgColor;
        document.getElementById('tat_tr' + actb_pos).style.width = actb_self.actb_fwidth;

        actb_pos = this.getAttribute('pos');
        var pCell = document.getElementById('tat_tr' + actb_pos).cells[1].innerText;


        for (var j = 0; j < document.getElementById('tbllist').rows.length; j++) {
            document.getElementById('tbllist').rows[j].style.backgroundColor = "";
            if ("tr_par" + pCell == document.getElementById('tbllist').rows[j].id) {
                document.getElementById('tbllist').rows[j].style.backgroundColor = '#DCFC5C';
            }

        }
        while (actb_pos < actb_rangeu) actb_moveup();
        while (actb_pos > actb_ranged) actb_movedown();
        document.getElementById('tat_tr' + actb_pos).style.backgroundColor = actb_self.actb_hColor;
        if (actb_toid) clearTimeout(actb_toid);
        if (actb_self.actb_timeOut > 0) actb_toid = setTimeout(function() { actb_mouse_on_list = 0; actb_removedisp(); }, actb_self.actb_timeOut);
    }
    /* ---- */

    function actb_insertword(a) {
        if (actb_self.actb_delimiter.length > 0) {
            str = '';
            l = 0;
            for (i = 0; i < actb_delimwords.length; i++) {
                if (actb_cdelimword == i) {
                    prespace = postspace = '';
                    gotbreak = false;
                    for (j = 0; j < actb_delimwords[i].length; ++j) {
                        if (actb_delimwords[i].charAt(j) != ' ') {
                            gotbreak = true;
                            break;
                        }
                        prespace += ' ';
                    }
                    for (j = actb_delimwords[i].length - 1; j >= 0; --j) {
                        if (actb_delimwords[i].charAt(j) != ' ') break;
                        postspace += ' ';
                    }
                    str += prespace;
                    str += a;
                    l = str.length;
                    if (gotbreak) str += postspace;
                } else {
                    str += actb_delimwords[i];
                }
                if (i != actb_delimwords.length - 1) {
                    str += actb_delimchar[i];
                }
            }
            actb_curr.value = str.split("@#$")[0];
            document.getElementById('hdnReceivedID').value = str.split("@#$")[1]
            setCaret(actb_curr, l);
        } else {
            actb_curr.value = a;
        }
        actb_mouse_on_list = 0;
        actb_removedisp();
    }
    function actb_penter() {
        if (!actb_display) return;
        actb_display = false;
        var word = '';
        var c = 0;
        for (var i = 0; i <= actb_self.actb_keywords.length; i++) {
            if (actb_bool[i]) c++;
            if (c == actb_pos) {
                word = actb_self.actb_keywords[i];
                break;
            }
        }
        actb_insertword(word);
        l = getCaretStart(actb_curr);
    }
    function actb_removedisp() {
        if (actb_mouse_on_list == 0) {
            actb_display = 0;
            if (document.getElementById('tat_table')) { document.body.removeChild(document.getElementById('tat_table')); }
            if (actb_toid) clearTimeout(actb_toid);
        }
    }
    function actb_keypress(e) {
        if (actb_caretmove) stopEvent(e);
        return !actb_caretmove;
    }
    function actb_checkkey(evt) {


        if (!evt) evt = event;
        a = evt.keyCode;
        caret_pos_start = getCaretStart(actb_curr);
        actb_caretmove = 0;
        switch (a) {
            case 38:
                actb_goup();
                actb_caretmove = 1;
                return false;
                break;
            case 40:
                actb_godown();
                actb_caretmove = 1;
                return false;
                break;
            case 13: case 9:
                if (actb_display) {
                    actb_caretmove = 1;
                    actb_penter();
                    return false;
                } else {
                    return true;
                }
                break;
            default:
                setTimeout(function() { actb_tocomplete(a) }, 50);
                break;
        }
    }

    function actb_tocomplete(kc) {

        if (kc == 38 || kc == 40 || kc == 13) return;
        var i;
        if (actb_display) {
            var word = 0;
            var c = 0;
            for (var i = 0; i <= actb_self.actb_keywords.length; i++) {
                if (actb_bool[i]) c++;
                if (c == actb_pos) {
                    word = i;
                    break;
                }
            }
            actb_pre = word;
        } else { actb_pre = -1 };

        if (actb_curr.value == '') {
            actb_mouse_on_list = 0;
            actb_removedisp();
            return;
        }
        if (actb_self.actb_delimiter.length > 0) {
            caret_pos_start = getCaretStart(actb_curr);
            caret_pos_end = getCaretEnd(actb_curr);

            delim_split = '';
            for (i = 0; i < actb_self.actb_delimiter.length; i++) {
                delim_split += actb_self.actb_delimiter[i];
            }
            delim_split = delim_split.addslashes();
            delim_split_rx = new RegExp("([" + delim_split + "])");
            c = 0;
            actb_delimwords = new Array();
            actb_delimwords[0] = '';

            for (i = 0, j = actb_curr.value.length; i < actb_curr.value.length; i++, j--) {
                if (actb_curr.value.substr(i, j).search(delim_split_rx) == 0) {
                    ma = actb_curr.value.substr(i, j).match(delim_split_rx);
                    actb_delimchar[c] = ma[1];
                    c++;
                    actb_delimwords[c] = '';
                } else {
                    actb_delimwords[c] += actb_curr.value.charAt(i);
                }
            }

            var l = 0;
            actb_cdelimword = -1;
            for (i = 0; i < actb_delimwords.length; i++) {
                if (caret_pos_end >= l && caret_pos_end <= l + actb_delimwords[i].length) {
                    actb_cdelimword = i;
                }
                l += actb_delimwords[i].length + 1;
            }
            var ot = actb_delimwords[actb_cdelimword].trim();
            var t = actb_delimwords[actb_cdelimword].addslashes().trim();
        } else {
            var ot = actb_curr.value;
            var t = actb_curr.value.addslashes();
        }
        if (ot.length == 0) {
            actb_mouse_on_list = 0;
            actb_removedisp();
        }
        if (ot.length < actb_self.actb_startcheck) return this;
        if (actb_self.actb_firstText) {
            var re = new RegExp("^" + t, "i");
        } else {
            var re = new RegExp(t, "i");
        }

        actb_total = 0;
        actb_tomake = false;
        actb_kwcount = 0;
        for (i = 0; i < actb_self.actb_keywords.length; i++) {
            actb_bool[i] = false;
            if (re.test(actb_self.actb_keywords[i])) {
                actb_total++;
                actb_bool[i] = true;
                actb_kwcount++;
                if (actb_pre == i) actb_tomake = true;
            }
        }

        if (actb_toid) clearTimeout(actb_toid);
        if (actb_self.actb_timeOut > 0) actb_toid = setTimeout(function() { actb_mouse_on_list = 0; actb_removedisp(); }, actb_self.actb_timeOut);
        actb_generate();
    }
    return this;
}

function doGetProductTotalQuantity(source, eventArgs) {

    var CostPriceShow = document.getElementById('hdnShowCostPrice').value;
    document.getElementById('tbllist').style.display = "none";
    if (document.getElementById('txtProduct').value.length < 2) {
        while (count = document.getElementById('tbllist').rows.length) {

            for (var j = 0; j < document.getElementById('tbllist').rows.length; j++) {
                document.getElementById('tbllist').deleteRow(j);
            }
        }
    } else {
        while (count = document.getElementById('tbllist').rows.length) {

            for (var j = 0; j < document.getElementById('tbllist').rows.length; j++) {
                document.getElementById('tbllist').deleteRow(j);
            }
        }

        var Headrow = document.getElementById('tbllist').insertRow(0);
        Headrow.id = "HeadID1";
        Headrow.style.fontWeight = "bold";
        Headrow.className = "dataheader1"
        var cell1 = Headrow.insertCell(0);
        var cell2 = Headrow.insertCell(1);
        var cell3 = Headrow.insertCell(2);
        var cell4 = Headrow.insertCell(3);
        if (CostPriceShow == "N") {
            // var cell5 = Headrow.insertCell(4);
        }
        else {
            var cell5 = Headrow.insertCell(4);
        }
        var cell6 = Headrow.insertCell(5);


        cell1.innerHTML = "Product";
        cell2.innerHTML = "Batch No";
        cell3.innerHTML = "Exp. Date";
        cell4.innerHTML = "Selling Price";
        if (CostPriceShow == "N") {

            // cell5.innerHTML = "Cost Price";
        }
        else {
            cell5.innerHTML = "Cost Price";
        }
        cell6.innerHTML = "Available Qty.";


        var lis = eventArgs.get_value().split('^');
        var sum = 0;
        var pcount = 0
        for (i = lis.length - 1; i >= 0; i--) {
            if (lis[i] != "") {
                var tblData = lis[i].split('~');
                //                    tblString[2] += "<tr><td>" + tblData[1] + "</td><td>" + tblData[0].split('|')[1] + "</td><td align='left'>" + tblData[8].trim().split(' ')[1] + "/" + tblData[8].trim().split(' ')[2] + "</td><td align='right'>" + tblData[3] + "(" + tblData[4] + ")" + "</td></tr>";
                var pdate = new Date();
                pdate = new Date(tblData[8]);
                var row = document.getElementById('tbllist').insertRow(1);
                row.style.height = "13px";
                row.id = "tr_par" + tblData[2];
                var cell1 = row.insertCell(0);
                var cell2 = row.insertCell(1);
                var cell3 = row.insertCell(2);
                var cell4 = row.insertCell(3);
                if (CostPriceShow == "N") {

                    // var cell5 = row.insertCell(4);
                }
                else {
                    var cell5 = row.insertCell(4);
                }
                var cell6 = row.insertCell(5);
                sum += parseFloat(tblData[3]);
                cell1.innerHTML = tblData[1];
                cell2.innerHTML = tblData[0].split('|')[1];
//                cell3.innerHTML = pdate.format("MMM/yyyy");
                cell3.innerHTML = pdate.format("MMM/yyyy") == "Jan/1753" ? "**" : pdate.format("MMM/yyyy");
                $('#hdnDisplaydata').val(parseFloat(tblData[5]).toFixed(2));
                cell4.innerHTML = ToTargetFormat($('#hdnDisplaydata'));  //parseFloat(tblData[5]).toFixed(2);
                if (CostPriceShow == "N") {
                    // cell5.innerHTML = tblData[14];
                }
                else {
                    $('#hdnDisplaydata').val(parseFloat(tblData[14]).toFixed(2));
                    cell5.innerHTML = ToTargetFormat($('#hdnDisplaydata'));
                }

                $('#hdnDisplaydata').val(tblData[3]);
                cell6.innerHTML = ToTargetFormat($('#hdnDisplaydata')) +"(" + tblData[4] + ")";
                pcount++;
            }

        }
        if (pcount > 0) {
            var fotrow = document.getElementById('tbllist').insertRow(pcount + 1);
            var fcell1 = fotrow.insertCell(0);
            var fcell2 = fotrow.insertCell(1);
            var fcell3 = fotrow.insertCell(2);
            var fcell4 = fotrow.insertCell(3);
            if (CostPriceShow == "N") {

                //  var fcell5 = fotrow.insertCell(4);
            }
            else {
                var fcell5 = fotrow.insertCell(4);
            }
            var fcell6 = fotrow.insertCell(5);
            fotrow.style.align = "right";
            if (CostPriceShow == "N") {
                fcell4.innerHTML = "Total";
            } else {
                fcell5.innerHTML = "Total";
            }
            // fcell5.innerHTML = "Total";
            $('#hdnDisplaydata').val(sum.toFixed(2));
            fcell6.innerHTML = ToTargetFormat($('#hdnDisplaydata'));
            document.getElementById('tbllist').style.display = "block";
        }

    }
}
function PatientGetProductKits(source, eventArgs) {
    var CostPriceShow = document.getElementById('hdnShowCostPrice').value;
    document.getElementById('tbllist').style.display = "none";
    if (document.getElementById('txtProduct').value.length < 2) {
        while (count = document.getElementById('tbllist').rows.length) {

            for (var j = 0; j < document.getElementById('tbllist').rows.length; j++) {
                document.getElementById('tbllist').deleteRow(j);
            }
        }
    } else {
        while (count = document.getElementById('tbllist').rows.length) {

            for (var j = 0; j < document.getElementById('tbllist').rows.length; j++) {
                document.getElementById('tbllist').deleteRow(j);
            }
        }

        var Headrow = document.getElementById('tbllist').insertRow(0);
        Headrow.id = "HeadID1";
        Headrow.style.fontWeight = "bold";
        Headrow.className = "dataheader1"
        var cell1 = Headrow.insertCell(0);
        var cell2 = Headrow.insertCell(1);
        var cell3 = Headrow.insertCell(2);
        var cell4 = Headrow.insertCell(3);
        if (CostPriceShow == "N") {

            //  var cell5 = Headrow.insertCell(4);
        }
        else {
            var cell5 = Headrow.insertCell(4);
        }
        var cell6 = Headrow.insertCell(5);
        var cell7 = Headrow.insertCell(6);

        cell1.innerHTML = "Product";
        cell2.innerHTML = "Batch No";
        cell3.innerHTML = "Exp. Date";
        cell4.innerHTML = "Selling Price";
        if (CostPriceShow == "N") {
            // cell5.innerHTML = "Cost Price";
        } else {
            cell5.innerHTML = "Cost Price";
        }
        cell6.innerHTML = "Available Qty.";
       // cell7.innerHTML = "<input id='chkAll' name='chkAll' onclick='chkSelectAll(document.form1.chkAll);' value='SelectAll' type='checkbox'>SelectAll</input>";
        


        var lis = eventArgs.get_value().split('^');
        var sum = 0;
        var pcount = 0
        for (i = lis.length - 1; i >= 0; i--) {
            if (lis[i] != "") {
                var tblData = lis[i].split('~');
                //                    tblString[2] += "<tr><td>" + tblData[1] + "</td><td>" + tblData[0].split('|')[1] + "</td><td align='left'>" + tblData[8].trim().split(' ')[1] + "/" + tblData[8].trim().split(' ')[2] + "</td><td align='right'>" + tblData[3] + "(" + tblData[4] + ")" + "</td></tr>";
                if (tblData[17] == 'Y') {

                    GetKitPrepDetails(tblData[0].split('|')[1], tblData[0].split('|')[0]);
                    document.getElementById('TableProductDetails').style.display = "none";
                }
                else {
                    document.getElementById('TableProductDetails').style.display = "block";
                    document.getElementById('kits').innerHTML = "";
                    var pdate = new Date();
                    pdate = new Date(tblData[8]);
                    var row = document.getElementById('tbllist').insertRow(1);
                    row.style.height = "13px";
                    row.id = "tr_par" + tblData[2];
                    var cell1 = row.insertCell(0);
                    var cell2 = row.insertCell(1);
                    var cell3 = row.insertCell(2);
                    var cell4 = row.insertCell(3);
                    if (CostPriceShow == "N") {
                        //var cell5 = row.insertCell(4);
                    }
                    else {
                        var cell5 = row.insertCell(4);
                    }
                    var cell6 = row.insertCell(5);
                    sum += parseFloat(tblData[3]);
                    cell1.innerHTML = tblData[1];
                    cell2.innerHTML = tblData[0].split('|')[1];
                    cell3.innerHTML = pdate.format("MMM/yyyy") == "Jan/1753" ? "**" : pdate.format("MMM/yyyy");
                    $('#hdnDisplaydata').val(parseFloat(tblData[5]).toFixed(2));
                    cell4.innerHTML = ToTargetFormat($('#hdnDisplaydata'));
                    if (CostPriceShow == "N") {
                        // cell5.innerHTML = tblData[18];
                    }
                    else {
                        $('#hdnDisplaydata').val(parseFloat(tblData[18]).toFixed(2));
                        cell5.innerHTML = ToTargetFormat($('#hdnDisplaydata'));
                    }
                    $('#hdnDisplaydata').val(tblData[3]);
                    cell6.innerHTML = ToTargetFormat($('#hdnDisplaydata')) + "(" + tblData[4] + ")";
                   
                    pcount++;
                }
            }

        }
        if (pcount > 0) {
            var fotrow = document.getElementById('tbllist').insertRow(pcount + 1);
            var fcell1 = fotrow.insertCell(0);
            var fcell2 = fotrow.insertCell(1);
            var fcell3 = fotrow.insertCell(2);
            var fcell4 = fotrow.insertCell(3);
            if (CostPriceShow == "N") {
                // var fcell5 = fotrow.insertCell(4);
            }
            else {
                var fcell5 = fotrow.insertCell(4);

            }
            var fcell6 = fotrow.insertCell(5);
            fotrow.style.align = "right";
            if (CostPriceShow == "N") {
                fcell4.innerHTML = "Total";
            } else {
                fcell5.innerHTML = "Total";
            }
            fcell6.innerHTML = sum.toFixed(2);
            document.getElementById('tbllist').style.display = "block";
        }

    }
}

function BillingGetProductTotalQuantity(source, eventArgs) {
    var CostPriceShow = document.getElementById('hdnShowCostPrice').value;
    document.getElementById('tbllist').style.display = "none";
    if (document.getElementById('txtProduct').value.length < 2) {
        while (count = document.getElementById('tbllist').rows.length) {

            for (var j = 0; j < document.getElementById('tbllist').rows.length; j++) {
                document.getElementById('tbllist').deleteRow(j);
            }
        }
    } else {
        while (count = document.getElementById('tbllist').rows.length) {

            for (var j = 0; j < document.getElementById('tbllist').rows.length; j++) {
                document.getElementById('tbllist').deleteRow(j);
            }
        }

        var Headrow = document.getElementById('tbllist').insertRow(0);
        Headrow.id = "HeadID1";
        Headrow.style.fontWeight = "bold";
        Headrow.className = "dataheader1"
        var cell1 = Headrow.insertCell(0);
        var cell2 = Headrow.insertCell(1);
        var cell3 = Headrow.insertCell(2);
        var cell4 = Headrow.insertCell(3);
        var cell5 = "";
        var cell6 ="";
        if (CostPriceShow == "N") {

            cell6 = Headrow.insertCell(4);
        }
        else {
            cell5 = Headrow.insertCell(4);
            cell6 = Headrow.insertCell(5);
        }




        //        cell1.innerHTML = "Product";
        //        cell2.innerHTML = "Batch No";
        //        cell3.innerHTML = "Exp. Date";
        //        cell4.innerHTML = "Selling Price";
        //        if (CostPriceShow == "N") {
        //            // cell5.innerHTML = "Cost Price";
        //        } else {
        //            cell5.innerHTML = "Cost Price";
        //        }
        //        cell6.innerHTML = "Available Qty.";


        cell1.innerHTML = Header.Product;
        cell2.innerHTML = Header.BatchNo;
        cell3.innerHTML = Header.ExpDate;
        cell4.innerHTML = Header.SellingPrice;
        if (CostPriceShow == "N") {

            // cell5.innerHTML = "Cost Price";
        }
        else {
            cell5.innerHTML = Header.CostPrice;
        }
        cell6.innerHTML = Header.AvailableQty;

        var lis = eventArgs.get_value().split('^');
        var sum = 0;
        var pcount = 0
        for (i = lis.length - 1; i >= 0; i--) {
            if (lis[i] != "") {
                var tblData = lis[i].split('~');
                //                if (tblData[17] == 'Y') {

                //                    GetKitPrepDetails(tblData[0].split('|')[1], tblData[0].split('|')[0]);
                //                }
                //                //                    tblString[2] += "<tr><td>" + tblData[1] + "</td><td>" + tblData[0].split('|')[1] + "</td><td align='left'>" + tblData[8].trim().split(' ')[1] + "/" + tblData[8].trim().split(' ')[2] + "</td><td align='right'>" + tblData[3] + "(" + tblData[4] + ")" + "</td></tr>";
                //                else {
                var pdate = new Date();
                pdate = new Date(tblData[8]);
                var row = document.getElementById('tbllist').insertRow(1);
                row.style.height = "13px";
                row.id = "tr_par" + tblData[2];
                var cell1 = row.insertCell(0);
                var cell2 = row.insertCell(1);
                var cell3 = row.insertCell(2);
                var cell4 = row.insertCell(3);
                var cell5 ="";
                var cell6 ="";
                if (CostPriceShow == "N") {
                    //var cell5 = row.insertCell(4);
                    cell6 =row.insertCell(4);
                }
                else {
                    cell5 = row.insertCell(4);
                    cell6 =row.insertCell(5);
                }
                //cell6 = row.insertCell(5);
                sum += parseFloat(tblData[3]);
                cell1.innerHTML = tblData[1];
                cell2.innerHTML = tblData[0].split('|')[1];
                cell3.innerHTML = pdate.format("MMM/yyyy") == "Jan/1753" ? "**" : pdate.format("MMM/yyyy");
                
                $('#hdnDisplaydata').val(parseFloat(tblData[5]).toFixed(2));
                cell4.innerHTML = ToTargetFormat($('#hdnDisplaydata'));
                
                if (CostPriceShow == "N") {
                    // cell5.innerHTML = tblData[18];
                }
                else {
                    $('#hdnDisplaydata').val(parseFloat(tblData[18]).toFixed(2));
                    cell5.innerHTML = ToTargetFormat($('#hdnDisplaydata'));
                }
                $('#hdnDisplaydata').val(tblData[3]);
                cell6.innerHTML = ToTargetFormat($('#hdnDisplaydata')) +"(" + tblData[4] + ")";
                pcount++;
            }
        }
         
      
        if (pcount > 0) {
            var fotrow = document.getElementById('tbllist').insertRow(pcount + 1);
            var fcell1 = fotrow.insertCell(0);
            var fcell2 = fotrow.insertCell(1);
            var fcell3 = fotrow.insertCell(2);
            var fcell4 = fotrow.insertCell(3);
            var fcell5 = "";
            var fcell6 = "";
            if (CostPriceShow == "N") {
                // var fcell5 = fotrow.insertCell(4);
                fcell6 = fotrow.insertCell(4);
            }
            else {
                fcell5 = fotrow.insertCell(4);
                fcell6 = fotrow.insertCell(5);

            }
            //var fcell6 = fotrow.insertCell(5);
            fotrow.style.align = "right";
            if (CostPriceShow == "N") {
                fcell4.innerHTML = "Total";
            } else {
                fcell5.innerHTML = "Total";
            }
            $('#hdnDisplaydata').val(sum.toFixed(2));
            // fcell6.innerHTML = sum.toFixed(2);
            fcell6.innerHTML = ToTargetFormat($('#hdnDisplaydata'));
            document.getElementById('tbllist').style.display = "block";
        }

    }
}
function StockretTotalQuantity(source, eventArgs) {

    document.getElementById('tbllist').style.display = "none";
    if (document.getElementById('txtProduct').value.length < 2) {
        while (count = document.getElementById('tbllist').rows.length) {

            for (var j = 0; j < document.getElementById('tbllist').rows.length; j++) {
                document.getElementById('tbllist').deleteRow(j);
            }
        }
    } else {
        while (count = document.getElementById('tbllist').rows.length) {

            for (var j = 0; j < document.getElementById('tbllist').rows.length; j++) {
                document.getElementById('tbllist').deleteRow(j);
            }
        }

        var Headrow = document.getElementById('tbllist').insertRow(0);
        Headrow.id = "HeadID1";
        Headrow.style.fontWeight = "bold";
        Headrow.className = "dataheader1"
        var cell1 = Headrow.insertCell(0);
        var cell2 = Headrow.insertCell(1);
        var cell3 = Headrow.insertCell(2);
        var cell4 = Headrow.insertCell(3);

        var cell5 = Headrow.insertCell(4);


        cell1.innerHTML = "Product";
        cell2.innerHTML = "Batch No";
        cell3.innerHTML = "CreatedAt Date";
        cell4.innerHTML = "Selling Price";
        cell5.innerHTML = "Available Qty.";


        var lis = eventArgs.get_value().split('^');
        var sum = 0;
        var pcount = 0
        for (i = lis.length - 1; i >= 0; i--) {
            if (lis[i] != "") {

                var y = lis[i].split('~');
                var tblData = lis[i].split('~');
                var pdate = new Date();
                pdate = new Date(tblData[8]);

                var row = document.getElementById('tbllist').insertRow(1);
                if (y[16] == 'Y') {
                    row.style.backgroundColor = "Green";
                }

                row.style.height = "13px";
                row.id = "tr_par" + tblData[11];
                var cell1 = row.insertCell(0);
                var cell2 = row.insertCell(1);
                var cell3 = row.insertCell(2);
                var cell4 = row.insertCell(3);
                var cell5 = row.insertCell(4);

                sum += parseFloat(tblData[5]);
                cell1.innerHTML = tblData[1];
                cell2.innerHTML = tblData[4];
                cell3.innerHTML = pdate.format("dd/MMM/yyyy");
                
                $('#hdnDisplaydata').val(parseFloat(tblData[9]).toFixed(2));
                cell4.innerHTML = ToTargetFormat($('#hdnDisplaydata'));

                $('#hdnDisplaydata').val(tblData[5]);
                cell5.innerHTML = ToTargetFormat($('#hdnDisplaydata')); +"(" + tblData[7] + ")";
                pcount++;
            }


        }
        if (pcount > 0) {
            var fotrow = document.getElementById('tbllist').insertRow(pcount + 1);
            var fcell1 = fotrow.insertCell(0);
            var fcell2 = fotrow.insertCell(1);
            var fcell3 = fotrow.insertCell(2);
            var fcell4 = fotrow.insertCell(3);
            var fcell5 = fotrow.insertCell(4);

            fotrow.style.align = "right";
            fcell4.innerHTML = "Total";
            fcell5.innerHTML = sum.toFixed(2);
            document.getElementById('tbllist').style.display = "block";
        }

        //        document.getElementById('tbllist').rows[j].style.backgroundColor = '#DCFC5C';

    }
}


function doClearTable() {
    if (document.getElementById('txtProduct').value.length < 2) {
        while (count = document.getElementById('tbllist').rows.length) {

            for (var j = 0; j < document.getElementById('tbllist').rows.length; j++) {
                document.getElementById('tbllist').deleteRow(j);
            }
        }
    }
}

function InvOpSubTable(tableObj) {
    
    var CostPriceShow = document.getElementById('hdnShowCostPrice').value;
    document.getElementById('tbllist').style.display = "none";
    while (count = document.getElementById('tbllist').rows.length) {

        for (var j = 0; j < document.getElementById('tbllist').rows.length; j++) {
            document.getElementById('tbllist').deleteRow(j);
        }
    }

    var Headrow = document.getElementById('tbllist').insertRow(0);
    Headrow.id = "HeadID1";
    Headrow.style.fontWeight = "bold";
    Headrow.className = "dataheader1"
    var cell1 = Headrow.insertCell(0);
    var cell2 = Headrow.insertCell(1);
    var cell3 = Headrow.insertCell(2);
    var cell4 = Headrow.insertCell(3);
    if (CostPriceShow == "N") {
        // var cell5 = Headrow.insertCell(4);
    }
    else {
        var cell5 = Headrow.insertCell(4);
    }
    var cell6 = Headrow.insertCell(5);


    cell1.innerHTML = "Product";
    cell2.innerHTML = "Batch No";
    cell3.innerHTML = "Exp. Date";
    cell4.innerHTML = "Selling Price";
    if (CostPriceShow == "N") {
        // cell5.innerHTML = "Cost Price";
    }
    else {
        cell5.innerHTML = "Cost Price";
    }
    cell6.innerHTML = "Available Qty.";


    var lis = tableObj.split('^');
    var sum = 0;
    var pcount = 0
    for (i = lis.length - 1; i >= 0; i--) {
        if (lis[i] != "") {
            var tblData = lis[i].split('~');
            var pdate = new Date();
            pdate = new Date(tblData[9]);
            var row = document.getElementById('tbllist').insertRow(1);
            row.style.height = "13px";
            row.id = "tr_par" + tblData[3];
            var cell1 = row.insertCell(0);
            var cell2 = row.insertCell(1);
            var cell3 = row.insertCell(2);
            var cell4 = row.insertCell(3);
            if (CostPriceShow == "N") {
                //var cell5 = row.insertCell(4);
            }
            else {
                var cell5 = row.insertCell(4);
            }
            var cell6 = row.insertCell(5);
            sum += parseFloat(tblData[4]);
            cell1.innerHTML = tblData[2];
            cell2.innerHTML = tblData[1];
//            cell3.innerHTML = pdate.format("MMM/yyyy");
            cell3.innerHTML = pdate.format("MMM/yyyy") == "Jan/1753" ? "**" : pdate.format("MMM/yyyy");

            $('#hdnDisplaydata').val(parseFloat(tblData[6]).toFixed(2));
            cell4.innerHTML = ToTargetFormat($('#hdnDisplaydata'));
            
            if (CostPriceShow == "N") {
                // cell5.innerHTML = tblData[19];
            }
            else {
                $('#hdnDisplaydata').val(parseFloat(tblData[19]).toFixed(2));
                cell5.innerHTML = ToTargetFormat($('#hdnDisplaydata'));

            }
            $('#hdnDisplaydata').val(tblData[4]);
            cell6.innerHTML = ToTargetFormat($('#hdnDisplaydata')) + "(" + tblData[5] + ")";
            pcount++;
        }

    }
    if (pcount > 0) {
        var fotrow = document.getElementById('tbllist').insertRow(pcount + 1);
        var fcell1 = fotrow.insertCell(0);
        var fcell2 = fotrow.insertCell(1);
        var fcell3 = fotrow.insertCell(2);
        var fcell4 = fotrow.insertCell(3);
        if (CostPriceShow == "N") {
            // var fcell5 = fotrow.insertCell(4);
        }
        else {
            var fcell5 = fotrow.insertCell(4);
        }
        var fcell6 = fotrow.insertCell(5);
        fotrow.style.align = "right";
        if (CostPriceShow == "N") {
            fcell4.innerHTML = "Total";
        } else {
            fcell5.innerHTML = "Total";
        }
        //fcell5.innerHTML = "Total";
        fcell6.innerHTML = sum.toFixed(2);
        document.getElementById('tbllist').style.display = "block";
    }

}


function SalesGetProductTotalQuantity(source, eventArgs) {
       
    var CostPriceShow = document.getElementById('hdnShowCostPrice').value;
    document.getElementById('tbllist').style.display = "none";
    if (document.getElementById('txtProductName').value.length < 2) {
        while (count = document.getElementById('tbllist').rows.length) {

            for (var j = 0; j < document.getElementById('tbllist').rows.length; j++) {
                document.getElementById('tbllist').deleteRow(j);
            }
        }
    } else {
        while (count = document.getElementById('tbllist').rows.length) {

            for (var j = 0; j < document.getElementById('tbllist').rows.length; j++) {
                document.getElementById('tbllist').deleteRow(j);
            }
        }

        var Headrow = document.getElementById('tbllist').insertRow(0);
        Headrow.id = "HeadID1";
        Headrow.style.fontWeight = "bold";
        Headrow.className = "dataheader1"
        var cell1 = Headrow.insertCell(0);
        var cell2 = Headrow.insertCell(1);
        var cell3 = Headrow.insertCell(2);
        var cell4 = Headrow.insertCell(3);
        if (CostPriceShow == "N") {

            //  var cell5 = Headrow.insertCell(4);
        }
        else {
            var cell5 = Headrow.insertCell(4);
        }
        var cell6 = Headrow.insertCell(5);
        var cell7 = Headrow.insertCell(6);
        var cell8 = Headrow.insertCell(7);
        var cell9 = Headrow.insertCell(8);
        var cell10 = Headrow.insertCell(9);


        cell1.innerHTML = "Product";
        cell2.innerHTML = "Batch No";
        cell3.innerHTML = "MFT.Date";
        cell4.innerHTML = "Exp.Date";
        cell5.innerHTML = "MFT.Code";
        cell6.innerHTML = "Rate";
        if (CostPriceShow == "N") {
            // cell5.innerHTML = "Cost Price";
        } else {
            cell7.innerHTML = "Cost Price";
        }
        cell8.innerHTML = "MRP";
        cell9.innerHTML = "UOM";
        cell10.innerHTML = "Available Qty.";


        var lis = eventArgs.get_value().split('^');
        var sum = 0;
        var pcount = 0
        for (i = lis.length - 1; i >= 0; i--) {
            if (lis[i] != "") {
                var tblData = lis[i].split('~');
                //                    tblString[2] += "<tr><td>" + tblData[1] + "</td><td>" + tblData[0].split('|')[1] + "</td><td align='left'>" + tblData[8].trim().split(' ')[1] + "/" + tblData[8].trim().split(' ')[2] + "</td><td align='right'>" + tblData[3] + "(" + tblData[4] + ")" + "</td></tr>";

                var pMFTdate = new Date();
                pMFTdate = new Date(tblData[3]);
                var pdate = new Date();
                pdate = new Date(tblData[4]);
                var row = document.getElementById('tbllist').insertRow(1);
                row.style.height = "13px";
                row.id = "tr_par" + tblData[2];
                var cell1 = row.insertCell(0);
                var cell2 = row.insertCell(1);
                var cell3 = row.insertCell(2);
                var cell4 = row.insertCell(3);
                var cell5 = row.insertCell(4);
                var cell6 = row.insertCell(5);
                if (CostPriceShow == "N") {
                    //var cell7 = row.insertCell(6);
                }
                else {
                    var cell7 = row.insertCell(6);
                }
                var cell8 = row.insertCell(7);
                var cell9 = row.insertCell(8);
                var cell10 = row.insertCell(9);
                sum += parseFloat(tblData[5]);
                cell1.innerHTML = tblData[1];
                cell2.innerHTML = tblData[2];
                cell3.innerHTML = pMFTdate.format("MMM/yyyy");
                cell4.innerHTML = pdate.format("MMM/yyyy");
                cell5.innerHTML = tblData[12];
                $('#hdnDisplaydata').val(parseFloat(tblData[9]).toFixed(2));
                cell6.innerHTML = ToTargetFormat($('#hdnDisplaydata'));
                if (CostPriceShow == "N") {
                    // cell7.innerHTML = tblData[8];
                }
                else {
                    cell7.innerHTML = parseFloat(tblData[8]).toFixed(2);
                }

                cell8.innerHTML = parseFloat(tblData[10]).toFixed(2);
                cell9.innerHTML = tblData[7];
                cell10.innerHTML = tblData[5] + "(" + tblData[7] + ")";
                pcount++;
            }

        }
        if (pcount > 0) {
            var fotrow = document.getElementById('tbllist').insertRow(pcount + 1);
            var fcell1 = fotrow.insertCell(0);
            var fcell2 = fotrow.insertCell(1);
            var fcell3 = fotrow.insertCell(2);
            var fcell4 = fotrow.insertCell(3);
            var fcell5 = fotrow.insertCell(4);
            var fcell6 = fotrow.insertCell(5);

            if (CostPriceShow == "N") {
                // var fcell7 = fotrow.insertCell(6);
            }
            else {
                var fcell7 = fotrow.insertCell(6);

            }
            var fcell8 = fotrow.insertCell(7);
            var fcell9 = fotrow.insertCell(8);
            var fcell10 = fotrow.insertCell(9);
            fotrow.style.align = "right";
            if (CostPriceShow == "N") {
                fcell8.innerHTML = "Total";
            } else {
                fcell9.innerHTML = "Total";
            }
            fcell10.innerHTML = sum.toFixed(2);
            document.getElementById('tbllist').style.display = "block";
        }

    }
}

function ProductSupplierlist(source, eventArgs) {

    document.getElementById('tbllist').style.display = "none";
    if (document.getElementById('txtProductName').value.length < 2) {
        while (count = document.getElementById('tbllist').rows.length) {

            for (var j = 0; j < document.getElementById('tbllist').rows.length; j++) {
                document.getElementById('tbllist').deleteRow(j);
            }
        }
    } else {
        while (count = document.getElementById('tbllist').rows.length) {

            for (var j = 0; j < document.getElementById('tbllist').rows.length; j++) {
                document.getElementById('tbllist').deleteRow(j);
            }
        }

        var Headrow = document.getElementById('tbllist').insertRow(0);
        Headrow.id = "HeadID1";
        Headrow.style.fontWeight = "bold";
        Headrow.className = "dataheader1"
        var cell1 = Headrow.insertCell(0);
        var cell2 = Headrow.insertCell(1);
        var cell3 = Headrow.insertCell(2);
        var cell4 = Headrow.insertCell(3);
        var cell5 = Headrow.insertCell(4);
        var cell6 = Headrow.insertCell(5);
        var cell7 = Headrow.insertCell(6);

        cell1.innerHTML = "Supplier Name";
        cell2.innerHTML = "Product Name";
        cell3.innerHTML = "Unit";
        cell4.innerHTML = "UnitPrice";
        cell5.innerHTML = "SellingPrice";
        cell6.innerHTML = "Tax";
        cell7.innerHTML = "Discount";


        var lis = eventArgs.get_value().split('^');
        var sum = 0;
        var pcount = 0
        for (i = lis.length - 1; i >= 0; i--) {

            if (lis[i] != "") {

                var y = lis[i].split('#');
                var pname = y[0].split('~')[1];
                var sname = y[0].split('~')[3];
                for (j = 0; j < y.length; j++) {
                    var tblData = y[j].split('~');

                    if (y[j].split('~')[4] == 'R') {
                        var row = document.getElementById('tbllist').insertRow(1);
                        row.style.height = "13px";
                        row.id = "tr_par" + tblData[11];
                        var cell1 = row.insertCell(0);
                        var cell2 = row.insertCell(1);
                        var cell3 = row.insertCell(2);
                        var cell4 = row.insertCell(3);
                        var cell5 = row.insertCell(4);
                        var cell6 = row.insertCell(5);
                        var cell7 = row.insertCell(6);

                        cell1.innerHTML = pname;
                        cell2.innerHTML = sname;
                        cell3.innerHTML = y[j].split('~')[0];
                        cell4.innerHTML = parseFloat(y[j].split('~')[1].trim()).toFixed(2);
                        cell5.innerHTML = parseFloat(y[j].split('~')[5].trim()).toFixed(2);
                        cell6.innerHTML = parseFloat(y[j].split('~')[6].trim()).toFixed(2);
                        cell7.innerHTML = parseFloat(y[j].split('~')[7].trim()).toFixed(2);

                        pcount++;
                    }

                }
                sname = "";
                pname = "";
            }

        }
        if (pcount > 0) {

            document.getElementById('tbllist').style.display = "block";
        }

        //        document.getElementById('tbllist').rows[j].style.backgroundColor = '#DCFC5C';

    }
}



namespace eSignatureSample
{
    partial class Window1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Wisej Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window1));
            Wisej.Web.Widget.Package package5 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package6 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package7 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package8 = new Wisej.Web.Widget.Package();
            this.widget1 = new Wisej.Web.Widget();
            this.widget1.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.label1 = new Wisej.Web.Label();
            this.button1 = new Wisej.Web.Button();
            this.pictureBox1 = new Wisej.Web.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // widget1
            // 
            this.widget1.BorderStyle = Wisej.Web.BorderStyle.None;

            this.widget1.Location = new System.Drawing.Point(50, 88);
            this.widget1.InitScript = $@"this.init = function() {{

            // your initialization code.
            var me = this;
            console.log(""last of init"");
           this.container.innerHTML = ""<table border='1'cellpadding='0' width='500'><tbody><tr><td><canvas id='cnv' name='cnv' width='304' height='99'></canvas></td><td><input type='hidden' id='hiddenText' name='hiddenText'</td></tr></tbody></table>"";
                let cnv = document.getElementById('cnv'); //the canvas that the signature image will be displayed once the signing process is complete
var ctx = cnv.getContext(""2d"");
ctx.font = ""15px Arial"";
            ctx.textAlign = ""center"";
            ctx.fillText(""Click to Sign"", cnv.width / 2, cnv.height / 2);
//document.getElementById(""SignBtn"").onclick = function () {{  
////OnSign();
////var newwindow = window.open(""HtmlPage1.html"",""test"",""width=500,height=400"");
////newwindow.onbeforeunload = function(){{
////        SetValue(document.getElementById('hiddenText').value)
////    }}
////newwindow.document.write(""HtmlPage1.html"");
//    }}
    }}

var SetValue = function(data) {{
var canvas = this.widget._canvas[0];
				var context = canvas.getContext(""2d"");

                var img = new Image;
            img.src = data; //specify image source 
            context.clearRect(0, 0, canvas.width, canvas.height);  // Clear specified pixel 
            img.onload = function() {{
                context.drawImage(img, 0, 0);
            }}
        }}


var OnSign = function()
  {{
   if(IsSigWebInstalled()){{
      var ctx = document.getElementById('cnv').getContext('2d');
      SetDisplayXSize( 500 );
      SetDisplayYSize( 100 );
      SetTabletState(0, tmr);
      SetJustifyMode(0);
      ClearTablet();
      if(tmr == null)
      {{
        tmr = SetTabletState(1, ctx, 50);
      }}
      else
      {{
        SetTabletState(0, tmr);
        tmr = null;
        tmr = SetTabletState(1, ctx, 50);
      }}
     }} else{{
    alert(""Unable to communicate with SigWeb.Please confirm that SigWeb is installed and running on this PC."");
    }}
  }}
  var IsSigWebInstalled = function()
            {{
                var baseUri = makeUri();
                var xhr = new XMLHttpRequest();
                try
                {{
                    xhr.onreadystatechange = function() {{
                        if (xhr.readyState == 4 && xhr.status == 0)
                        {{
                            console.log(""Unknown Error Occured. SigWeb Service response not received."");
                            return false;
                        }}
                    }};
                    xhr.open(""GET"", baseUri + ""TabletState"" + ""?noCache="" + generateUUID(), false);
                    xhr.send();
                }}
                catch (e)
                {{
                    console.log('catch', e);
                }}

                return (xhr.status != 404 && xhr.status != 0);
            }}

var makeUri = function() {{
console.log(""inmakeur"");
    var prot = location.protocol;
	if(prot == 'file:')
	{{
		prot = 'http:';
	}}

	if (isIE()) {{
		if (prot == 'https:') {{
			return (prot + ""//tablet.sigwebtablet.com:47290/SigWeb/"");
		}}
		else {{
			return (prot + ""//tablet.sigwebtablet.com:47289/SigWeb/"");
		}}
	}}
if (isChrome()) {{
		if (prot == 'https:') {{
			return (prot + ""//tablet.sigwebtablet.com:47290/SigWeb/"");
		}}
		else {{
			return (prot + ""//tablet.sigwebtablet.com:47289/SigWeb/"");
		}}
	}}

	else {{
		//FIREFOX
		if (prot == 'https:') {{
			return (prot + ""//tablet.sigwebtablet.com:47290/SigWeb/"");
		}}
		else {{
			return (prot + ""//tablet.sigwebtablet.com:47289/SigWeb/"");
		}}
	}}
}}
var isIE = function() {{

	return ((navigator.appName == 'Microsoft Internet Explorer') || ((navigator.appName == 'Netscape') && (new RegExp(""Trident/.*rv:([0-9]{{1,}}[\.0-9]{{0,}})"").exec
	(navigator.userAgent) != null)));
}}
 var isChrome = function() {{
    var ua = navigator.userAgent;
	var chrome = false;

	//Javascript Browser Detection - Chrome
	if (ua.lastIndexOf('Chrome/') > 0) {{
		//var version = ua.substr(ua.lastIndexOf('Chrome/') + 7, 2);
		return true;
	}}
	else {{
		return false;
	}}
}}

function generateUUID() {{
    var d = new Date().getTime();
	if (typeof performance !== 'undefined' && typeof performance.now === 'function'){{
		d += performance.now(); //use high-precision timer if available
	}}
	return 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function (c) {{
		var r = (d + Math.random() * 16) % 16 | 0;
		d = Math.floor(d / 16);
		return (c === 'x' ? r : (r & 0x3 | 0x8)).toString(16);
	}});
}}";

            this.widget1.Name = "widget1";
			package5.Name = "Topaz.js";
			package5.Source = "/Topaz.js";
			//this.widget1.Packages.Add(package5);
			this.widget1.Size = new System.Drawing.Size(500, 174);
			this.widget1.TabIndex = 0;
			this.widget1.Text = "widget1";
			this.widget1.WidgetEvent += new Wisej.Web.WidgetEventHandler(this.widget1_WidgetEvent);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(50, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Sign Here:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(304, 307);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(129, 42);
			this.button1.TabIndex = 2;
			this.button1.Text = "OK";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.pictureBox1.Location = new System.Drawing.Point(50, 291);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(159, 58);
			this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			// 
			// Window1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 371);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.widget1);
			this.Name = "Window1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Widget widget1;
		private Wisej.Web.Label label1;
		private Wisej.Web.Button button1;
		private Wisej.Web.PictureBox pictureBox1;
	}
}
//this.widget1.InitScript = $@"this.init = function() {{

//            // your initialization code.
//            var me = this;
//            console.log(""last of init"");
//           this.container.innerHTML = ""<table border='1'cellpadding='0' width='500'><tbody><tr><td><canvas id='cnv' name='cnv' width='304' height='99'></canvas></td><td><input id='SignBtn' name ='SignBtn' type='button' value='Sign'></td></tr></tbody></table>"";
//                let cnv = document.getElementById('cnv'); //the canvas that the signature image will be displayed once the signing process is complete
//var ctx = cnv.getContext(""2d"");
//ctx.font = ""15px Arial"";
//            ctx.textAlign = ""center"";
//            ctx.fillText(""Click to Sign"", cnv.width / 2, cnv.height / 2);
////cnv.addEventListener(""click"", function(){{ this.StartSign(); }});
//           //cnv.onmousedown = function(){{

//           //                this.StartSign();

//           // }};
//            //< tbody >< tr >
//            //  < td height = '100' width = '500' >

//            //       < canvas id = 'cnv' name = 'cnv' width = '500' height = '100' ></ canvas >

//            //          </ td >

//            //         < td > < input id = 'SignBtn' name = 'SignBtn' type = 'button' value = 'Sign' onclick = ""onSign()"" >

//            //                     </ td >


//            //                     </ tr >

//            //                   </ tbody ></ table > "";
//            console.log(""last of init"");
//this.widget = $(this.container);
//this.fireEvent(""initialized"");
//        }}


//var SetValues = function(objResponse, imageWidth, imageHeight)
//	{{
//        var obj = null;
//		if(typeof(objResponse) === 'string'){{
//			obj = JSON.parse(objResponse);
//		}} else{{
//			obj = JSON.parse(JSON.stringify(objResponse));
//		}}		
		
//	    var ctx = document.getElementById('cnv').getContext('2d');

//			if (obj.errorMsg != null && obj.errorMsg!="""" && obj.errorMsg!=""undefined"")
//			{{
//                alert(obj.errorMsg);
//            }}
//            else
//			{{
//                if (obj.isSigned)
//				{{
//                    document.FORM1.sigRawData.value += obj.imageData;
//					document.FORM1.sigStringData.value += obj.sigString;
//					var img = new Image();
//					img.onload = function () 
//					{{
//						ctx.drawImage(img, 0, 0, imageWidth, imageHeight);
//					}}
//					img.src = ""data:image/png;base64,"" + obj.imageData;
//                }}
//            }}
//    }}
//var SignResponse = function(event)
//	{{
//        var str = event.target.getAttribute(""msgAttribute"");
//		var obj = JSON.parse(str);
//		SetValues(obj, imgWidth, imgHeight);
//	}}
//var imgWidth;
//	var imgHeight;
//this.StartSign = function(){{
        
//            if (!this.widget) {{
//            this.addListenerOnce(""initialized"", function(){{ this.StartSign(); }});

//            return;
//        }}
//        var isInstalled = document.documentElement.getAttribute('SigPlusExtLiteExtension-installed');  
//	    if (!isInstalled) {{
//	        alert(""SigPlusExtLite extension is either not installed or disabled. Please install or enable extension."");
//			return;
//	    }}	
//	    var canvasObj = document.getElementById('cnv');
//		canvasObj.getContext('2d').clearRect(0, 0, canvasObj.width, canvasObj.height);
//		//document.FORM1.sigStringData.value = ""SigString: "";
//		//document.FORM1.sigRawData.value = ""Base64 String: "";
//		imgWidth = canvasObj.width;
//		imgHeight = canvasObj.height;
//		var message = {{ ""firstName"": """", ""lastName"": """", ""eMail"": """", ""location"": """", ""imageFormat"": 1, ""imageX"": imgWidth, ""imageY"": imgHeight, ""imageTransparency"": false, ""imageScaling"": false, ""maxUpScalePercent"": 0.0, ""rawDataFormat"": ""ENC"", ""minSigPoints"": 25 }};
			
//		top.document.addEventListener('SignResponse', SignResponse, false);
//		var messageData = JSON.stringify(message);
//		var element = document.createElement(""MyExtensionDataElement"");
//		element.setAttribute(""messageAttribute"", messageData);
//		document.documentElement.appendChild(element);
//		var evt = document.createEvent(""Events"");
//		evt.initEvent(""SignStartEvent"", true, false);				
//		element.dispatchEvent(evt);		
//}}


//this.onSign = function()
//        {{

//            var ctx = document.getElementById('cnv').getContext('2d');
//            SetDisplayXSize(this.getWidth() + ""px"" );
//            SetDisplayYSize(this.getHeight() + ""px"" );
//            SetTabletState(0, tmr);
//            SetJustifyMode(0);
//            ClearTablet();
//            SetKeyString(""0000000000000000"");
//            SetEncryptionMode(0);
//            if (tmr == null)
//            {{
//                tmr = SetTabletState(1, ctx, 50);
//            }}
//            else
//            {{
//                SetTabletState(0, tmr);
//                tmr = null;
//                tmr = SetTabletState(1, ctx, 50);
//            }}
//        }}

//this.onDone = function()
//        {{

//            if (NumberOfTabletPoints() == 0)
//            {{
//                alert(""Please sign before continuing"");
//            }}
//            else
//            {{
//                SetTabletState(0, tmr);
//                //RETURN TOPAZ-FORMAT SIGSTRING
//                SetSigCompressionMode(1);
//                //document.FORM1.bioSigData.value=GetSigString();
//                //$(“#sigStringData).text += GetSigString();
//                //this returns the signature in Topaz’s own format, with biometric information

//                //RETURN BMP BYTE ARRAY CONVERTED TO BASE64 STRING
//                SetImageXSize(275);
//                SetImageYSize(60);
//                SetImagePenWidth(5);
//                GetSigImageB64(SigImageCallback);

//            }}
//        }}

//        function SigImageCallback(str )
//        {{
//            var txt1 = document.getElementsByName(""sigStringData"")[0];
//            txt1.value = str;

//        }}";

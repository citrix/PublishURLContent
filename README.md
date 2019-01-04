# Citrix Content Publishing Utility

The purpose of this utility is to help Citrix administrators publish "content" or URLs into your Citrix XenApp/XenDesktop environments using a GUI based tool. While the ability to publish content is available already, it currently only exists from the Powershell cmdlets. This tool is currently
built to be used on a XenApp/XenDesktop server or as a published application.

![](images/pc-image1.png)
![](images/pc-image2.png)
![](images/pc-image3.png)
## Usage

### Publishing new URL Content

1. DeliveryGroup - Select the delivery group where you would like to URL published to.

2. Display Name - Type in the display name for the published URL. This is what the your users will see.

3. Description - Description of the URL that you are publishing to your users

4. Application Icon - This is the icon you would like associated with the URL you publish. This icon will be displayed to the user either within Storefront or Receiver

    - If an image doesn't already exist you can use the "Image Management" tab to upload a new icon.

Once you have filled in all the fields, in order to publish your content URL to you will need to hit the "Publish" toolbar button. 

![](images/publish-btn.png)

### Listing existing URL Content

If you would like to see all the URL content that is published on your environment you can use the "Existing URL Content" tab.

1. Once on this tab, you can use the "List Content" button to see all of the published URLs in your environment. 

    ![](images/list-btn.png)

### Upload new icon for use with applications

If you need to upload a new icon to the broker to use as an application icon you can use the "Icon Management" tab.

1. To upload a new icon, hit the "Upload Image" button and select a png or jpeg file. The process will convert the image to the appropiate format (.ico) and then upload to the broker.
![](images/upload-btn.png)

## Code

### Prerequisites

[Visual Studio](http://www.visualstudio.com) Community edition should be just fine for this project

[Windows](https://www.microsoft.com/en-us/windows/get-windows-10)

[Citrix XenApp/XenDesktop](https://www.citrix.com/community/citrix-developer/)

### Cloning the repo
    git clone https://github.com/citrix/PublishURLContent.git

// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace DragDrop
{
	[Register ("CollectionCell")]
	partial class CollectionCell
	{
		[Outlet]
		UIKit.UIImageView cellPicture { get; set; }

		[Outlet]
		UIKit.UILabel descriptionLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (cellPicture != null) {
				cellPicture.Dispose ();
				cellPicture = null;
			}

			if (descriptionLabel != null) {
				descriptionLabel.Dispose ();
				descriptionLabel = null;
			}
		}
	}
}

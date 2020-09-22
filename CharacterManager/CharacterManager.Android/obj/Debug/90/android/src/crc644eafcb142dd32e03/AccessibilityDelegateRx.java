package crc644eafcb142dd32e03;


public class AccessibilityDelegateRx
	extends android.view.View.AccessibilityDelegate
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_addExtraDataToAccessibilityNodeInfo:(Landroid/view/View;Landroid/view/accessibility/AccessibilityNodeInfo;Ljava/lang/String;Landroid/os/Bundle;)V:GetAddExtraDataToAccessibilityNodeInfo_Landroid_view_View_Landroid_view_accessibility_AccessibilityNodeInfo_Ljava_lang_String_Landroid_os_Bundle_Handler\n" +
			"n_onInitializeAccessibilityEvent:(Landroid/view/View;Landroid/view/accessibility/AccessibilityEvent;)V:GetOnInitializeAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_Handler\n" +
			"n_onInitializeAccessibilityNodeInfo:(Landroid/view/View;Landroid/view/accessibility/AccessibilityNodeInfo;)V:GetOnInitializeAccessibilityNodeInfo_Landroid_view_View_Landroid_view_accessibility_AccessibilityNodeInfo_Handler\n" +
			"n_onPopulateAccessibilityEvent:(Landroid/view/View;Landroid/view/accessibility/AccessibilityEvent;)V:GetOnPopulateAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_Handler\n" +
			"n_sendAccessibilityEvent:(Landroid/view/View;I)V:GetSendAccessibilityEvent_Landroid_view_View_IHandler\n" +
			"n_sendAccessibilityEventUnchecked:(Landroid/view/View;Landroid/view/accessibility/AccessibilityEvent;)V:GetSendAccessibilityEventUnchecked_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_Handler\n" +
			"";
		mono.android.Runtime.register ("Android.Views.AccessibilityDelegateRx, ReactiveUI.Events", AccessibilityDelegateRx.class, __md_methods);
	}


	public AccessibilityDelegateRx ()
	{
		super ();
		if (getClass () == AccessibilityDelegateRx.class)
			mono.android.TypeManager.Activate ("Android.Views.AccessibilityDelegateRx, ReactiveUI.Events", "", this, new java.lang.Object[] {  });
	}


	public void addExtraDataToAccessibilityNodeInfo (android.view.View p0, android.view.accessibility.AccessibilityNodeInfo p1, java.lang.String p2, android.os.Bundle p3)
	{
		n_addExtraDataToAccessibilityNodeInfo (p0, p1, p2, p3);
	}

	private native void n_addExtraDataToAccessibilityNodeInfo (android.view.View p0, android.view.accessibility.AccessibilityNodeInfo p1, java.lang.String p2, android.os.Bundle p3);


	public void onInitializeAccessibilityEvent (android.view.View p0, android.view.accessibility.AccessibilityEvent p1)
	{
		n_onInitializeAccessibilityEvent (p0, p1);
	}

	private native void n_onInitializeAccessibilityEvent (android.view.View p0, android.view.accessibility.AccessibilityEvent p1);


	public void onInitializeAccessibilityNodeInfo (android.view.View p0, android.view.accessibility.AccessibilityNodeInfo p1)
	{
		n_onInitializeAccessibilityNodeInfo (p0, p1);
	}

	private native void n_onInitializeAccessibilityNodeInfo (android.view.View p0, android.view.accessibility.AccessibilityNodeInfo p1);


	public void onPopulateAccessibilityEvent (android.view.View p0, android.view.accessibility.AccessibilityEvent p1)
	{
		n_onPopulateAccessibilityEvent (p0, p1);
	}

	private native void n_onPopulateAccessibilityEvent (android.view.View p0, android.view.accessibility.AccessibilityEvent p1);


	public void sendAccessibilityEvent (android.view.View p0, int p1)
	{
		n_sendAccessibilityEvent (p0, p1);
	}

	private native void n_sendAccessibilityEvent (android.view.View p0, int p1);


	public void sendAccessibilityEventUnchecked (android.view.View p0, android.view.accessibility.AccessibilityEvent p1)
	{
		n_sendAccessibilityEventUnchecked (p0, p1);
	}

	private native void n_sendAccessibilityEventUnchecked (android.view.View p0, android.view.accessibility.AccessibilityEvent p1);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}

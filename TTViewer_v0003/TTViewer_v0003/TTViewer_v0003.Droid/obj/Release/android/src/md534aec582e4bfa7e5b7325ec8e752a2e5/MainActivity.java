package md534aec582e4bfa7e5b7325ec8e752a2e5;


public class MainActivity
	extends md5d4dd78677dce656d5db26c85a3743ef3.FormsApplicationActivity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onTitleChanged:(Ljava/lang/CharSequence;I)V:GetOnTitleChanged_Ljava_lang_CharSequence_IHandler\n" +
			"";
		mono.android.Runtime.register ("TTViewer_v0003.Droid.MainActivity, TTViewer_v0003.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MainActivity.class, __md_methods);
	}


	public MainActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MainActivity.class)
			mono.android.TypeManager.Activate ("TTViewer_v0003.Droid.MainActivity, TTViewer_v0003.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onTitleChanged (java.lang.CharSequence p0, int p1)
	{
		n_onTitleChanged (p0, p1);
	}

	private native void n_onTitleChanged (java.lang.CharSequence p0, int p1);

	java.util.ArrayList refList;
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

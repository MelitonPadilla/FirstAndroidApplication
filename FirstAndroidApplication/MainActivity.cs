using Android.App;
using Android.Widget;
using Android.OS;

namespace FirstAndroidApplication
{
    [Activity(Label = "FirstAndroidApplication", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private CheckBox chkLambdaDelegate;
        private CheckBox chkDelegate;
        private CheckBox chkAnonymousDelegate;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            TextView txt = (TextView)FindViewById(Resource.Id.txtDateOutput);
            txt.Text = System.DateTime.Now.ToString();

            Button btnDelegate = (Button)FindViewById(Resource.Id.btnDelegate);
            Button btnAnonymousDelegate = (Button)FindViewById(Resource.Id.btnAnonymousDelegate);
            Button btnLambda = (Button)FindViewById(Resource.Id.btnLambda);
            Button btnSquareValue = (Button)FindViewById(Resource.Id.btnSquareValue);
            chkDelegate = (CheckBox)FindViewById(Resource.Id.chkDelegate);
            chkAnonymousDelegate = (CheckBox)FindViewById(Resource.Id.chkAnonymousDelegate);
            chkLambdaDelegate = (CheckBox)FindViewById(Resource.Id.chkLambdaDelegate);

            // Set click for square value
            btnSquareValue.Click += btnSquareValue_Click;

            // set click for checkbox delegate
            chkDelegate.Click += ChkDelegate_Click;

            // set chkAnonymousDelegate
            chkAnonymousDelegate.Click += delegate
            {
                if (chkAnonymousDelegate.Checked)
                {
                    txt.Text = System.DateTime.Now.ToString() + " Click Checked";
                }
                else
                {
                    txt.Text = System.DateTime.Now.ToString() + " Click Unchecked";
                }

            };

            //Set lamba click
            chkLambdaDelegate.Click += (sender, args) =>
                {
                    txt = (TextView)FindViewById(Resource.Id.txtDateOutput);
                    if (chkLambdaDelegate.Checked)
                    {
                        txt.Text = System.DateTime.Now.ToString() + " Click Checked";
                    }
                    else
                    {
                        txt.Text = System.DateTime.Now.ToString() + " Click Unchecked";
                    }
                };

            // set click for button
            btnDelegate.Click += btnDelegate_Click;

            // set anonymous click
            btnAnonymousDelegate.Click += delegate
            {
                txt.Text = System.DateTime.Now.ToString();
            
            };

            // set lambda click
            btnLambda.Click += (sender, args) =>
                { txt.Text = System.DateTime.Now.ToString(); };

            

        }

        void ChkDelegate_Click(object sender, System.EventArgs args)
        {
            TextView txt = (TextView)FindViewById(Resource.Id.txtDateOutput);
            if (chkDelegate.Checked)
            {
                txt.Text = System.DateTime.Now.ToString() + " Click Checked";
            }
            else
            {
                txt.Text = System.DateTime.Now.ToString() + " Click Unchecked";
            }
        }

        void btnDelegate_Click(object sender, System.EventArgs args)
        {
            TextView txt = (TextView)FindViewById(Resource.Id.txtDateOutput);
            txt.Text = System.DateTime.Now.ToString();

        }

        // Button Click event handler to square input
        void btnSquareValue_Click(object sender, System.EventArgs args)
        {
            // Get the widget references
            EditText etNumberIn = (EditText)FindViewById(Resource.Id.etNumberIn);
            TextView txtNumberOut = (TextView)FindViewById(Resource.Id.txtNumberOut);

            double inputConverted;

            // conver input to a number
            inputConverted = System.Convert.ToDouble(etNumberIn.Text);

            // Square the number. Conver the result to a string and display output
            txtNumberOut.Text = (inputConverted * inputConverted).ToString();


        }

    }
}


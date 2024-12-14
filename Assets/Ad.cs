using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using System.Drawing;
using UnityEngine.UIElements;
public class Ad : MonoBehaviour
{
   // public GameObject player;
    BannerView bannerView;
    InterstitialAd interstitialAd;


    void Start()
    {
        bannerView = new BannerView("ca-app-pub-6890270918658888/2876149234", AdSize.Banner, AdPosition.Bottom);
        var addr = new AdRequest();
        bannerView.LoadAd(addr);

        if (interstitialAd != null)
        {
            interstitialAd.Destroy();
            interstitialAd = null;
        }

        var adRequest = new AdRequest();

        InterstitialAd.Load("ca-app-pub-6890270918658888/7936904227", adRequest,
            (InterstitialAd ad, LoadAdError error) =>
            {
                if (error != null || ad == null)
                {

                    return;
                }


                interstitialAd = ad;
            });


        if (interstitialAd != null && interstitialAd.CanShowAd())
        {
            interstitialAd.Show();
        }
    }
}
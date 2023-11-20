using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class TestBanner : MonoBehaviour
{
    private BannerView bannerView;

    [SerializeField] private string appID = "ca-app-pub-3940256099942544~3347511713";      
    [SerializeField] private string bannerID = "ca-app-pub-3940256099942544/6300978111";

    private void Awake()
    {
        MobileAds.Initialize(initStatus => { });
    }

    private void Start()
    {
        RequestBanner();
    }

    private void RequestBanner()
    {
        bannerView = new BannerView(bannerID, AdSize.Leaderboard, AdPosition.Bottom);
        AdRequest request = new AdRequest.Builder().Build();
        bannerView.LoadAd(request);
    }
}

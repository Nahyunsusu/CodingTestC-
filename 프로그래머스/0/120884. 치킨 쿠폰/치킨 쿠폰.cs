using System;

public class Solution
{
    public int solution(int chicken)
    {
        int couponChicken = 0;
        int coupon = chicken;
        int rest = 0;

        while(coupon >= 10)
        {
            int newCouponChicken = coupon / 10;
            rest = coupon % 10;

            couponChicken += newCouponChicken;

            coupon = newCouponChicken + rest;
        }

        return couponChicken;
    }
}
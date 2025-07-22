using System;
using Xunit;


public class Tester
{	
    private double epsilon = 1e-6;

    [Fact]
    public void AccountCannotHaveNegativeOverdraftLimit()
    {
        Account account = new Account(-20);
        
        Assert.Equal(0, account.OverdraftLimit);
    }
    
    [Fact]
    public void DepositCannotHaveNegativeOverdraftLimit()
    {
        Account account = new Account(-20);
        
        Assert.False(account.Deposit(-20));
    }
    
     
    [Fact]
    public void WithdrawCannotHaveNegativeOverdraftLimit()
    {
        Account account = new Account(-20);
        
        Assert.False(account.Withdraw(-20));
    }
    
    [Fact]
    public void DepositCorrectBalance()
    {
        Account account = new Account(0);
        
        var result = account.Deposit(20);
        
        Assert.Equal(20, account.Balance);
        Assert.True(result);
    }
    
    [Fact]
    public void WithdrawCorrectBalance()
    {
        Account account = new Account(0);
        
        account.Deposit(50);
        account.Withdraw(20);
        
        Assert.Equal(30, account.Balance);
    }
}
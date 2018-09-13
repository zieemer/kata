<h1>Checkout</h1>

[Based on the Kata09 at codekata.com]

We're going to implement a supermarket checkout that calculates the total price of a number of items. In a normal supermarket, things are identified using Stock Keeping Units, or SKUs. In our store, we’ll use individual letters of the alphabet (A, B, C, and so on). Our goods are priced individually.

Additionally some items are multipriced: buy n of them, and they’ll cost you y units. For example, item ‘A’ might cost 50 units individually, but this week we have a special offer: buy three ‘A’s and they’ll cost you 130 units. In fact this week’s prices are:

<table>
<thead>
<tr>
<th>Item</th>
<th>Unit price</th>
<th>Special offer</th>
</tr>
</thead>
<tbody>
<tr>
<td>A</td>
<td>50</td>
<td>3 for 130</td>
</tr>
<tr>
<td>B</td>
<td>30</td>
<td>2 for 45</td>
</tr>
<tr>
<td>C</td>
<td>20</td>
<td></td>
</tr>
<tr>
<td>D</td>
<td>15</td>
<td></td>
</tr></tbody></table>

Our checkout accepts items in any order, so that if we scan a B, an A, and another B, we’ll recognize the two B’s and price them at 45 (for a total price so far of 95).

The interface for the checkout should match the following:

<pre><code>public interface ICheckout
{
  void Scan(string sku);
  int GetTotal();
}
</code></pre>

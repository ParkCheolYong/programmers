SELECT A.PRODUCT_ID
     , A.PRODUCT_NAME
	 , SUM(A.PRICE * B.AMOUNT) AS TOTAL_SALES
  FROM FOOD_PRODUCT A
       INNER JOIN FOOD_ORDER B ON B.PRODUCT_ID = A.PRODUCT_ID
 WHERE B.PRODUCE_DATE LIKE '2022-05%' 	   
 GROUP BY
       A.PRODUCT_ID
     , A.PRODUCT_NAME
 ORDER BY 	
       TOTAL_SALES DESC
	 , A.PRODUCT_ID;
SELECT A.AUTHOR_ID
     , A.AUTHOR_NAME
	 , B.CATEGORY
	 , SUM(B.PRICE * C.SALES) AS TOTAL_SALES
  FROM AUTHOR A 
       INNER JOIN BOOK B ON B.AUTHOR_ID = A.AUTHOR_ID
	   INNER JOIN (SELECT BOOK_ID
	                    , SUM(SALES) AS SALES
					 FROM BOOK_SALES 
				    WHERE SALES_DATE LIKE '2022-01%'
				    GROUP BY BOOK_ID) C ON B.BOOK_ID = C.BOOK_ID
 GROUP BY
       A.AUTHOR_ID
     , B.CATEGORY
 ORDER BY
       A.AUTHOR_ID
     , B.CATEGORY DESC;
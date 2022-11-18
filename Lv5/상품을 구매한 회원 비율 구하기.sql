SELECT YEAR(B.SALES_DATE)                                  AS YEAR
     , MONTH(B.SALES_DATE)                                 AS MONTH
     , COUNT(DISTINCT(A.USER_ID))                          AS PUCHASED_USERS
     , ROUND((COUNT(DISTINCT(A.USER_ID)) / A.TOT_CNT) , 1) AS PUCHASED_RATIO
  FROM (
         SELECT USER_ID                                               AS USER_ID
              , (SELECT COUNT(*) 
                   FROM USER_INFO 
                  WHERE JOINED BETWEEN '2021-01-01' AND '2021-12-31') AS TOT_CNT
           FROM USER_INFO A
          WHERE JOINED BETWEEN '2021-01-01' AND '2021-12-31'
        ) A
          INNER JOIN ONLINE_SALE B ON A.USER_ID = B.USER_ID
 WHERE B.SALES_DATE BETWEEN '2022-01-01' AND '2022-12-31'
 GROUP BY 
       YEAR
     , MONTH 
 ORDER BY
       YEAR
     , MONTH